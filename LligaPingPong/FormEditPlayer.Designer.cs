﻿namespace LligaPingPong
{
    partial class FormEditPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPlayer));
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panePlayerUploadAvatar = new System.Windows.Forms.PictureBox();
            this.panePlayerAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panePlayerUploadAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panePlayerAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "DNI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Inactive",
            "Active"});
            this.comboBox1.Location = new System.Drawing.Point(297, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(183, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(337, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Player Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 17;
            // 
            // panePlayerUploadAvatar
            // 
            this.panePlayerUploadAvatar.BackColor = System.Drawing.Color.Transparent;
            this.panePlayerUploadAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panePlayerUploadAvatar.BackgroundImage")));
            this.panePlayerUploadAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panePlayerUploadAvatar.Location = new System.Drawing.Point(12, 159);
            this.panePlayerUploadAvatar.Name = "panePlayerUploadAvatar";
            this.panePlayerUploadAvatar.Size = new System.Drawing.Size(156, 156);
            this.panePlayerUploadAvatar.TabIndex = 19;
            this.panePlayerUploadAvatar.TabStop = false;
            this.panePlayerUploadAvatar.Visible = false;
            this.panePlayerUploadAvatar.Click += new System.EventHandler(this.panePlayerUploadAvatar_Click);
            this.panePlayerUploadAvatar.MouseLeave += new System.EventHandler(this.panePlayerAvatar_MouseLeave);
            // 
            // panePlayerAvatar
            // 
            this.panePlayerAvatar.BackColor = System.Drawing.Color.Black;
            this.panePlayerAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panePlayerAvatar.BackgroundImage")));
            this.panePlayerAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panePlayerAvatar.Location = new System.Drawing.Point(12, 12);
            this.panePlayerAvatar.Name = "panePlayerAvatar";
            this.panePlayerAvatar.Size = new System.Drawing.Size(156, 156);
            this.panePlayerAvatar.TabIndex = 18;
            this.panePlayerAvatar.TabStop = false;
            this.panePlayerAvatar.Click += new System.EventHandler(this.panePlayerAvatar_Click);
            this.panePlayerAvatar.MouseEnter += new System.EventHandler(this.panePlayerAvatar_MouseHover);
            // 
            // FormAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 174);
            this.Controls.Add(this.panePlayerUploadAvatar);
            this.Controls.Add(this.panePlayerAvatar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPlayer";
            this.Text = "FormAddPlayer";
            this.Load += new System.EventHandler(this.FormAddPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panePlayerUploadAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panePlayerAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox panePlayerUploadAvatar;
        private System.Windows.Forms.PictureBox panePlayerAvatar;
    }
}