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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(76, 175, 80);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(75, 80);
            button1.Name = "button1";
            button1.Size = new Size(250, 60);
            button1.TabIndex = 1;
            button1.Text = "OYUNA BAŞLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnOyunuBaslat_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(244, 67, 54);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(75, 150);
            button2.Name = "button2";
            button2.Size = new Size(250, 60);
            button2.TabIndex = 0;
            button2.Text = "OYUNU KAPAT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnOyunuKapat_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(450, 77);
            label1.TabIndex = 0;
            label1.Text = "SAYISAL LOTO OYUNU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu_Tasarim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(450, 350);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu_Tasarim";
            Text = "AnaMenu";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
    }
}