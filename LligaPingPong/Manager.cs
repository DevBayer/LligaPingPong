using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Data;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LligaPingPong
{
    class Manager
    {
        FirebaseClient firebase = new FirebaseClient("https://lligapingpong.firebaseio.com/");

        public FirebaseClient client()
        {
            return firebase;
        }

        public async Task AddLeague(League league)
        {
            await ((Firebase.Database.Query.ChildQuery)firebase.Child((string)"leagues")).PostAsync(league);
        }

        public void ObservableLeagues(DataGridView grid, ComboBox combo)
        {
            try
            {
                DataTable myTab = new DataTable();
                myTab.Columns.Add("ID");
                myTab.Columns.Add("League");
                myTab.Columns.Add("Status");
                myTab.Columns.Add("Matches");
                var child = ((Firebase.Database.Query.ChildQuery)firebase.Child((string)"leagues"));
                var observable = child.AsObservable<InboundLeague>();
                var subscription = observable
                    .Where(f => !string.IsNullOrEmpty(f.Key))
                    .Subscribe(f =>
                    {
                        f.Object.key = f.Key;
                         if (f.EventType == Firebase.Database.Streaming.FirebaseEventType.InsertOrUpdate)
                        {
                            combo.Invoke((MethodInvoker)delegate {
                                //combo.Items.Add(f.Object.Name);
                                combo.Items.Add(f.Object);
                                combo.Refresh();
                            });
                            myTab.Rows.Add(f.Key, f.Object.Name, f.Object.Status, f.Object.Matches_played + "/" + f.Object.Total_matches);
                        }else if (f.EventType == Firebase.Database.Streaming.FirebaseEventType.Delete)
                        {
                            combo.Invoke((MethodInvoker)delegate {
                                combo.Items.Remove(f.Object);
                                combo.Refresh();
                            });
                            for (int v = 0; v < grid.Rows.Count; v++)
                            {
                                if (string.Equals(grid[0, v].Value as string, f.Key))
                                {
                                    grid.Rows.RemoveAt(v);
                                    v--; // this just got messy. But you see my point.
                                }
                            }
                        }
                        grid.Invoke((MethodInvoker)delegate {
                            grid.Refresh();
                        });
                    }                    
                    );

                grid.DataSource = myTab;
                grid.Refresh();
            }
            catch (System.IO.FileLoadException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ObservableLeague(String key, DataGridView grid)
        {
            try
            {
                DataTable myTab = new DataTable();
                myTab.Columns.Add("ID");
                myTab.Columns.Add("Name");
                myTab.Columns.Add("Points");
                var child = ((Firebase.Database.Query.ChildQuery)firebase.Child((string)"players")).Child(key);
                var observable = child.AsObservable<InboundLeague>();
                var subscription = observable
                    .Where(f => !string.IsNullOrEmpty(f.Key))
                    .Subscribe(f =>
                    {
                        f.Object.key = f.Key;
                        if (f.EventType == Firebase.Database.Streaming.FirebaseEventType.InsertOrUpdate)
                        {
                            myTab.Rows.Add(f.Key, f.Object.Name, f.Object.Status, f.Object.Matches_played + "/" + f.Object.Total_matches);
                        }
                        else if (f.EventType == Firebase.Database.Streaming.FirebaseEventType.Delete)
                        {
                            for (int v = 0; v < grid.Rows.Count; v++)
                            {
                                if (string.Equals(grid[0, v].Value as string, f.Key))
                                {
                                    grid.Rows.RemoveAt(v);
                                    v--; // this just got messy. But you see my point.
                                }
                            }
                        }
                        grid.Invoke((MethodInvoker)delegate {
                            grid.Refresh();
                        });
                    }
                    );

                grid.DataSource = myTab;
                grid.Refresh();
            }
            catch (System.IO.FileLoadException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
