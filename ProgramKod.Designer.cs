﻿namespace UygulamaDenemesi
{
    partial class UygulumaCalismaKodları
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Timer1 = new System.Windows.Forms.Timer(components);
            btnUretimiBaslat = new Button();
            lblDegerInput = new Label();
            progressBar = new TrackBar();
            txtInput = new TextBox();
            listBox1 = new ListBox();
            lblRandom = new Label();
            lblSayilar = new Label();
            btnInput = new Button();
            ReelTime = new System.Windows.Forms.Timer(components);
            btnClose = new Button();
            listBoxEkleme = new ListBox();
            ((System.ComponentModel.ISupportInitialize)progressBar).BeginInit();
            SuspendLayout();
            // 
            // Timer1
            // 
            Timer1.Interval = 10;
            Timer1.Tick += Timer1_Tick;
            // 
            // btnUretimiBaslat
            // 
            btnUretimiBaslat.BackColor = Color.FromArgb(34, 193, 195);
            btnUretimiBaslat.FlatStyle = FlatStyle.Flat;
            btnUretimiBaslat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUretimiBaslat.ForeColor = Color.White;
            btnUretimiBaslat.Location = new Point(12, 115);
            btnUretimiBaslat.Name = "btnUretimiBaslat";
            btnUretimiBaslat.Size = new Size(187, 40);
            btnUretimiBaslat.TabIndex = 31;
            btnUretimiBaslat.Text = "Şanslı Sayını Üret";
            btnUretimiBaslat.UseVisualStyleBackColor = false;
            btnUretimiBaslat.Click += btnUretimiBaslat_Click;
            // 
            // lblDegerInput
            // 
            lblDegerInput.AutoSize = true;
            lblDegerInput.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDegerInput.ForeColor = Color.Teal;
            lblDegerInput.Location = new Point(221, 115);
            lblDegerInput.Name = "lblDegerInput";
            lblDegerInput.Size = new Size(396, 32);
            lblDegerInput.TabIndex = 30;
            lblDegerInput.Text = "0-9 ARASI 10 TANE SAYI GİRİNİZ:";
            // 
            // progressBar
            // 
            progressBar.AutoSize = false;
            progressBar.BackColor = SystemColors.ActiveCaption;
            progressBar.Location = new Point(12, 47);
            progressBar.Maximum = 9;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(273, 33);
            progressBar.SmallChange = 0;
            progressBar.TabIndex = 5;
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.FromArgb(245, 245, 245);
            txtInput.Font = new Font("Segoe UI", 12F);
            txtInput.ForeColor = Color.Black;
            txtInput.Location = new Point(307, 156);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 34);
            txtInput.TabIndex = 16;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.NavajoWhite;
            listBox1.Cursor = Cursors.PanWest;
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listBox1.ForeColor = Color.Red;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 161);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(59, 204);
            listBox1.TabIndex = 17;
            // 
            // lblRandom
            // 
            lblRandom.AutoSize = true;
            lblRandom.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblRandom.Location = new Point(12, 9);
            lblRandom.Name = "lblRandom";
            lblRandom.Size = new Size(300, 22);
            lblRandom.TabIndex = 19;
            lblRandom.Text = "RANDOM SAYI OLUŞTURUCU";
            // 
            // lblSayilar
            // 
            lblSayilar.AutoSize = true;
            lblSayilar.Location = new Point(23, 81);
            lblSayilar.Name = "lblSayilar";
            lblSayilar.Size = new Size(70, 20);
            lblSayilar.TabIndex = 24;
            lblSayilar.Text = "lblSayilar";
            // 
            // btnInput
            // 
            btnInput.BackColor = Color.FromArgb(33, 150, 243);
            btnInput.FlatAppearance.BorderSize = 0;
            btnInput.FlatStyle = FlatStyle.Flat;
            btnInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInput.ForeColor = Color.White;
            btnInput.Location = new Point(221, 150);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(80, 40);
            btnInput.TabIndex = 0;
            btnInput.Text = "EKLE";
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            // 
            // ReelTime
            // 
            ReelTime.Interval = 1000;
            ReelTime.Tick += ReelTime_Tick;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(244, 67, 54);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(12, 382);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 59);
            btnClose.TabIndex = 0;
            btnClose.Text = "OYUNU KAPAT";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnOyunuKapatForm_Click;
            // 
            // listBoxEkleme
            // 
            listBoxEkleme.BackColor = Color.FromArgb(240, 240, 240);
            listBoxEkleme.BorderStyle = BorderStyle.FixedSingle;
            listBoxEkleme.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBoxEkleme.ForeColor = Color.Black;
            listBoxEkleme.FormattingEnabled = true;
            listBoxEkleme.ItemHeight = 23;
            listBoxEkleme.Location = new Point(423, 156);
            listBoxEkleme.Name = "listBoxEkleme";
            listBoxEkleme.Size = new Size(51, 232);
            listBoxEkleme.TabIndex = 26;
            // 
            // UygulumaCalismaKodları
            // 
            BackColor = Color.FromArgb(220, 230, 241);
            ClientSize = new Size(682, 453);
            Controls.Add(btnClose);
            Controls.Add(btnInput);
            Controls.Add(listBoxEkleme);
            Controls.Add(lblSayilar);
            Controls.Add(lblRandom);
            Controls.Add(listBox1);
            Controls.Add(txtInput);
            Controls.Add(progressBar);
            Controls.Add(lblDegerInput);
            Controls.Add(btnUretimiBaslat);
            ForeColor = Color.Teal;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UygulumaCalismaKodları";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SAYİSAL LOTO";
            ((System.ComponentModel.ISupportInitialize)progressBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer Timer1;
        private Button btnUretimiBaslat;
        private Label lblDegerInput;
        private TrackBar progressBar;
        private TextBox txtInput;
        private ListBox listBox1;
        private Label lblRandom;
        private Label lblSayilar;
        private Button btnInput;
        private System.Windows.Forms.Timer ReelTime;
        private Button btnClose;
        private ListBox listBoxEkleme;
    }
}
