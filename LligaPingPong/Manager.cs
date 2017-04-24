using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LligaPingPong
{
    class Manager
    {
        FirebaseClient firebase = new FirebaseClient("https://lligapingpong.firebaseio.com/");
        String bucketStorage = "lligapingpong.appspot.com";

        public FirebaseClient client()
        {
            return firebase;
        }

        public async Task AddLeague(League league)
        {
            await ((Firebase.Database.Query.ChildQuery)firebase.Child((string)"leagues")).PostAsync(league);
        }

        public async Task AddPlayer(Player player)
        {
            var saved = await ((Firebase.Database.Query.ChildQuery)firebase.Child((string)"players")).PostAsync(player);
            uploadPlayerAvatar(saved.Key, player.AbsolutePhoto);
        }

        public async Task UpdatePlayer(Player player)
        {
            var saved = await ((Firebase.Database.Query.ChildQuery)firebase.Child((string)"players/"+ player.key)).PostAsync(player);
            uploadPlayerAvatar(saved.Key, player.AbsolutePhoto);
        }

        public Task<Player> GetPlayer(String id)
        {
            var dinos = firebase.Child("players/" + id).OnceSingleAsync<Player>();
            return dinos;

        }

        public void ObservablePlayers(DataGridView grid)
        {
            try
            {
                DataTable myTab = new DataTable();
                myTab.Columns.Add("ID");
                myTab.Columns.Add("Photo", typeof(byte[]));
                myTab.Columns.Add("DNI");
                myTab.Columns.Add("Player Name");
                myTab.Columns.Add("Status");
                var child = ((Firebase.Database.Query.ChildQuery)firebase.Child((string)"players"));
                var observable = child.AsObservable<InboundPlayer>();
                var subscription = observable
                    .Where(f => !string.IsNullOrEmpty(f.Key))
                    .Subscribe(f =>
                    {
                        f.Object.key = f.Key;
                        if (f.EventType == Firebase.Database.Streaming.FirebaseEventType.InsertOrUpdate)
                        {
                            Image img = Image.FromFile(f.Object.AbsolutePhoto);
                            img = resizeImage(img, new Size(100, 100));
                            myTab.Rows.Add(f.Key, imageToByteArray(img), f.Object.Dni, f.Object.Name, f.Object.Status);
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
                            grid.Update();
                            grid.Refresh();
                            grid.Focus();
                        });
                        
                    }
                    );

                grid.DataSource = myTab;
                grid.Focus();
                grid.Update();
                grid.Refresh();
            }
            catch (System.IO.FileLoadException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public void ObservableLeagues(DataGridView grid)
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
                            myTab.Rows.Add(f.Key, f.Object.Name, f.Object.Status, f.Object.Matches_played + "/" + f.Object.Total_matches);
                        }else if (f.EventType == Firebase.Database.Streaming.FirebaseEventType.Delete)
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

        internal void uploadPlayerAvatar(string player, string photoPlayer)
        {
            try
            {
                var stream = System.IO.File.OpenRead(photoPlayer);
                // Constructr FirebaseStorage, path to where you want to upload the file and Put it there
                var task = new FirebaseStorage(bucketStorage)
                    .Child("players")
                    .Child(player)
                    .Child(System.IO.Path.GetFileName(photoPlayer))
                    .PutAsync(stream);
            }
            catch (Exception e)
            {

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
