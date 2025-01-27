using System.Drawing.Drawing2D;

namespace LotoUygulaması
{
    partial class Menu_Tasarim
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
            btnPlay = new Button();
            btnExit = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(50, 205, 50);
            btnPlay.Cursor = Cursors.Hand;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(117, 80);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(200, 50);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "OYUNA BAŞLA";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnOyunuBaslat_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 69, 58);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(117, 150);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 50);
            btnExit.TabIndex = 1;
            btnExit.Text = "OYUNU KAPAT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnOyunuKapat_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 77);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SAYISAL LOTO OYUNU";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu_Tasarim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(450, 350);
            Controls.Add(lblTitle);
            Controls.Add(btnExit);
            Controls.Add(btnPlay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu_Tasarim";
            Text = "AnaMenu";
            this.MaximizeBox = false;
            ResumeLayout(false);
        }

        #endregion
        private Button btnPlay;
        private Button btnExit;
        private Label lblTitle;
    }
}