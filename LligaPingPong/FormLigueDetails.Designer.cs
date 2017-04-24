namespace LligaPingPong
{
    partial class FormLigueDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLigueDetails));
            this.LigueDetails = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panePlayer = new System.Windows.Forms.Panel();
            this.panePlayerUploadAvatar = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panePlayerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panePlayerAvatar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panePlayerTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LigueDetails.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panePlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panePlayerUploadAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panePlayerAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LigueDetails
            // 
            this.LigueDetails.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.LigueDetails.Controls.Add(this.tabPage1);
            this.LigueDetails.Controls.Add(this.tabPage2);
            this.LigueDetails.Controls.Add(this.tabPage3);
            this.LigueDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LigueDetails.Location = new System.Drawing.Point(12, 12);
            this.LigueDetails.Name = "LigueDetails";
            this.LigueDetails.SelectedIndex = 0;
            this.LigueDetails.Size = new System.Drawing.Size(850, 429);
            this.LigueDetails.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panePlayer);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classification";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(842, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Matches";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panePlayer
            // 
            this.panePlayer.Controls.Add(this.panePlayerUploadAvatar);
            this.panePlayer.Controls.Add(this.button4);
            this.panePlayer.Controls.Add(this.button2);
            this.panePlayer.Controls.Add(this.panePlayerName);
            this.panePlayer.Controls.Add(this.label3);
            this.panePlayer.Controls.Add(this.panePlayerAvatar);
            this.panePlayer.Controls.Add(this.pictureBox1);
            this.panePlayer.Controls.Add(this.panePlayerTitle);
            this.panePlayer.Location = new System.Drawing.Point(299, 6);
            this.panePlayer.Name = "panePlayer";
            this.panePlayer.Size = new System.Drawing.Size(537, 388);
            this.panePlayer.TabIndex = 7;
            this.panePlayer.Visible = false;
            // 
            // panePlayerUploadAvatar
            // 
            this.panePlayerUploadAvatar.BackColor = System.Drawing.Color.Transparent;
            this.panePlayerUploadAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panePlayerUploadAvatar.BackgroundImage")));
            this.panePlayerUploadAvatar.Location = new System.Drawing.Point(27, 218);
            this.panePlayerUploadAvatar.Name = "panePlayerUploadAvatar";
            this.panePlayerUploadAvatar.Size = new System.Drawing.Size(156, 156);
            this.panePlayerUploadAvatar.TabIndex = 8;
            this.panePlayerUploadAvatar.TabStop = false;
            this.panePlayerUploadAvatar.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(449, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "Delete";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(189, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 34);
            this.button2.TabIndex = 5;
            this.button2.Tag = "save";
            this.button2.Text = "Save";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panePlayerName
            // 
            this.panePlayerName.Location = new System.Drawing.Point(189, 89);
            this.panePlayerName.Name = "panePlayerName";
            this.panePlayerName.Size = new System.Drawing.Size(321, 20);
            this.panePlayerName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Player Name";
            // 
            // panePlayerAvatar
            // 
            this.panePlayerAvatar.BackColor = System.Drawing.Color.Black;
            this.panePlayerAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panePlayerAvatar.BackgroundImage")));
            this.panePlayerAvatar.Location = new System.Drawing.Point(27, 71);
            this.panePlayerAvatar.Name = "panePlayerAvatar";
            this.panePlayerAvatar.Size = new System.Drawing.Size(156, 156);
            this.panePlayerAvatar.TabIndex = 2;
            this.panePlayerAvatar.TabStop = false;
            this.panePlayerAvatar.Click += new System.EventHandler(this.panePlayerAvatar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(27, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 10);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panePlayerTitle
            // 
            this.panePlayerTitle.AutoSize = true;
            this.panePlayerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panePlayerTitle.Location = new System.Drawing.Point(21, 19);
            this.panePlayerTitle.Name = "panePlayerTitle";
            this.panePlayerTitle.Size = new System.Drawing.Size(147, 33);
            this.panePlayerTitle.TabIndex = 0;
            this.panePlayerTitle.Text = "PaneTitle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(286, 388);
            this.dataGridView1.TabIndex = 6;
            // 
            // FormLigueDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 448);
            this.Controls.Add(this.LigueDetails);
            this.Name = "FormLigueDetails";
            this.Text = "FormLigueDetails";
            this.Load += new System.EventHandler(this.FormLigueDetails_Load);
            this.LigueDetails.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panePlayer.ResumeLayout(false);
            this.panePlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panePlayerUploadAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panePlayerAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LigueDetails;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panePlayer;
        private System.Windows.Forms.PictureBox panePlayerUploadAvatar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox panePlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox panePlayerAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label panePlayerTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}