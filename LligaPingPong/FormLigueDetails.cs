using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LligaPingPong
{
    public partial class FormLigueDetails : Form
    {
        public FormLigueDetails()
        {
            InitializeComponent();
            panePlayerAvatar.MouseHover += new EventHandler(panePlayerAvatar_MouseHover);
            panePlayerAvatar.MouseLeave += new EventHandler(panePlayerAvatar_MouseLeave);
            panePlayerUploadAvatar.Parent = panePlayerAvatar;
            panePlayerUploadAvatar.BackColor = Color.WhiteSmoke;
            panePlayerUploadAvatar.Top = 0;
            panePlayerUploadAvatar.Left = 0;
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

        private void FormLigueDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
