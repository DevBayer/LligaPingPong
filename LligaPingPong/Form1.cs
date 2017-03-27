using System;
using System.Data;
using System.Drawing;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LligaPingPong
{
    public partial class Form1 : Form
    {

        Manager manager = new Manager();
        DataTable t = new DataTable();

        public Form1()
        {
            InitializeComponent();
            panePlayerAvatar.MouseHover += new EventHandler(panePlayerAvatar_MouseHover);
            panePlayerAvatar.MouseLeave += new EventHandler(panePlayerAvatar_MouseLeave);
            panePlayerUploadAvatar.Parent = panePlayerAvatar;
            panePlayerUploadAvatar.BackColor = Color.WhiteSmoke;
            panePlayerUploadAvatar.Top = 0;
            panePlayerUploadAvatar.Left = 0;


            dataGridView2.DataSource = t;
            runLeague();
        }

        private async Task runLeague()
        {
            Manager man = new Manager();
            man.ObservableLeagues(dataGridView2, comboBoxLeagues);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panePlayerAvatar_MouseHover(object sender, EventArgs e)
        {
                panePlayerUploadAvatar.Visible = true;
        }



        private void panePlayerAvatar_MouseLeave(object sender, EventArgs e)
        {
            panePlayerUploadAvatar.Visible = false;
        }

        private void panePlayerAvatar_Click(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var window = new FormLigue();
            window.StartPosition = FormStartPosition.CenterParent;
            window.ShowDialog(this);
            if (window.leagueName.Length > 0)
            {
                League l = new League();
                l.Name = window.leagueName;
                l.Status = window.leagueStatus;
                l.Total_matches = window.leagueMatches;
                await manager.AddLeague(l);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //manager.getLeague(comboBoxLeagues.Text);
            League l = (League) comboBoxLeagues.SelectedItem;

            dataGridView1.Visible = true;


        }
    }
}
