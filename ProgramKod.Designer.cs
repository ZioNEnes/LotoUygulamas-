namespace UygulamaDenemesi
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
            BarHız = new System.Windows.Forms.Timer(components);
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
            btnKart1 = new Button();
            btnKart2 = new Button();
            btnKart3 = new Button();
            btnKartDegis = new Button();
            btnKart5 = new Button();
            listKart1 = new ListBox();
            listKart2 = new ListBox();
            listKart3 = new ListBox();
            listKart4 = new ListBox();
            btnKart4 = new Button();
            listKart5 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)progressBar).BeginInit();
            SuspendLayout();
            // 
            // BarHız
            // 
            BarHız.Interval = 10;
            BarHız.Tick += Timer1_Tick;
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
            lblDegerInput.Location = new Point(337, 9);
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
            txtInput.Location = new Point(423, 50);
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
            btnInput.Location = new Point(337, 44);
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
            listBoxEkleme.Location = new Point(739, 21);
            listBoxEkleme.Name = "listBoxEkleme";
            listBoxEkleme.Size = new Size(51, 232);
            listBoxEkleme.TabIndex = 26;
            // 
            // btnKart1
            // 
            btnKart1.BackColor = Color.Red;
            btnKart1.ForeColor = Color.FromArgb(0, 0, 192);
            btnKart1.Location = new Point(225, 161);
            btnKart1.Name = "btnKart1";
            btnKart1.Size = new Size(51, 29);
            btnKart1.TabIndex = 32;
            btnKart1.Text = "1";
            btnKart1.UseVisualStyleBackColor = false;
            // 
            // btnKart2
            // 
            btnKart2.BackColor = Color.FromArgb(255, 255, 128);
            btnKart2.ForeColor = SystemColors.ActiveCaptionText;
            btnKart2.Location = new Point(300, 161);
            btnKart2.Name = "btnKart2";
            btnKart2.Size = new Size(51, 29);
            btnKart2.TabIndex = 33;
            btnKart2.Text = "2";
            btnKart2.UseVisualStyleBackColor = false;
            // 
            // btnKart3
            // 
            btnKart3.BackColor = Color.FromArgb(255, 128, 255);
            btnKart3.ForeColor = Color.FromArgb(255, 255, 128);
            btnKart3.Location = new Point(387, 161);
            btnKart3.Name = "btnKart3";
            btnKart3.Size = new Size(51, 29);
            btnKart3.TabIndex = 34;
            btnKart3.Text = "3";
            btnKart3.UseVisualStyleBackColor = false;
            // 
            // btnKartDegis
            // 
            btnKartDegis.Location = new Point(612, 287);
            btnKartDegis.Name = "btnKartDegis";
            btnKartDegis.Size = new Size(94, 54);
            btnKartDegis.TabIndex = 35;
            btnKartDegis.Text = "Kartları Degiş";
            btnKartDegis.UseVisualStyleBackColor = true;
            btnKartDegis.Click += btnKartDegis_Click;
            // 
            // btnKart5
            // 
            btnKart5.BackColor = Color.FromArgb(128, 255, 128);
            btnKart5.ForeColor = Color.Black;
            btnKart5.Location = new Point(546, 161);
            btnKart5.Name = "btnKart5";
            btnKart5.Size = new Size(51, 29);
            btnKart5.TabIndex = 36;
            btnKart5.Text = "5";
            btnKart5.UseVisualStyleBackColor = false;
            // 
            // listKart1
            // 
            listKart1.BackColor = Color.Red;
            listKart1.BorderStyle = BorderStyle.FixedSingle;
            listKart1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listKart1.ForeColor = Color.FromArgb(0, 0, 192);
            listKart1.FormattingEnabled = true;
            listKart1.ItemHeight = 23;
            listKart1.Location = new Point(225, 196);
            listKart1.Name = "listKart1";
            listKart1.Size = new Size(51, 232);
            listKart1.TabIndex = 37;
            // 
            // listKart2
            // 
            listKart2.BackColor = Color.FromArgb(255, 255, 128);
            listKart2.BorderStyle = BorderStyle.FixedSingle;
            listKart2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listKart2.ForeColor = SystemColors.ActiveCaptionText;
            listKart2.FormattingEnabled = true;
            listKart2.ItemHeight = 23;
            listKart2.Location = new Point(300, 196);
            listKart2.Name = "listKart2";
            listKart2.Size = new Size(51, 232);
            listKart2.TabIndex = 38;
            // 
            // listKart3
            // 
            listKart3.BackColor = Color.FromArgb(255, 128, 255);
            listKart3.BorderStyle = BorderStyle.FixedSingle;
            listKart3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listKart3.ForeColor = Color.FromArgb(255, 255, 128);
            listKart3.FormattingEnabled = true;
            listKart3.ItemHeight = 23;
            listKart3.Location = new Point(387, 196);
            listKart3.Name = "listKart3";
            listKart3.Size = new Size(51, 232);
            listKart3.TabIndex = 39;
            // 
            // listKart4
            // 
            listKart4.BackColor = Color.FromArgb(128, 128, 255);
            listKart4.BorderStyle = BorderStyle.FixedSingle;
            listKart4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listKart4.ForeColor = Color.FromArgb(255, 255, 128);
            listKart4.FormattingEnabled = true;
            listKart4.ItemHeight = 23;
            listKart4.Location = new Point(470, 196);
            listKart4.Name = "listKart4";
            listKart4.Size = new Size(51, 232);
            listKart4.TabIndex = 41;
            // 
            // btnKart4
            // 
            btnKart4.BackColor = Color.FromArgb(128, 128, 255);
            btnKart4.ForeColor = Color.FromArgb(255, 255, 128);
            btnKart4.Location = new Point(470, 161);
            btnKart4.Name = "btnKart4";
            btnKart4.Size = new Size(51, 29);
            btnKart4.TabIndex = 40;
            btnKart4.Text = "4";
            btnKart4.UseVisualStyleBackColor = false;
            // 
            // listKart5
            // 
            listKart5.BackColor = Color.FromArgb(128, 255, 128);
            listKart5.BorderStyle = BorderStyle.FixedSingle;
            listKart5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listKart5.ForeColor = Color.Black;
            listKart5.FormattingEnabled = true;
            listKart5.ItemHeight = 23;
            listKart5.Location = new Point(546, 196);
            listKart5.Name = "listKart5";
            listKart5.Size = new Size(51, 232);
            listKart5.TabIndex = 42;
            // 
            // UygulumaCalismaKodları
            // 
            BackColor = Color.FromArgb(220, 230, 241);
            ClientSize = new Size(870, 450);
            Controls.Add(listKart5);
            Controls.Add(listKart4);
            Controls.Add(btnKart4);
            Controls.Add(listKart3);
            Controls.Add(listKart2);
            Controls.Add(listKart1);
            Controls.Add(btnKart5);
            Controls.Add(btnKartDegis);
            Controls.Add(btnKart3);
            Controls.Add(btnKart2);
            Controls.Add(btnKart1);
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
            Text = "SAYISAL LOTO";
            ((System.ComponentModel.ISupportInitialize)progressBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer BarHız;
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
        private Button btnKart1;
        private Button btnKart2;
        private Button btnKart3;
        private Button btnKartDegis;
        private Button btnKart5;
        private ListBox listKart1;
        private ListBox listKart2;
        private ListBox listKart3;
        private ListBox listKart4;
        private Button btnKart4;
        private ListBox listKart5;
    }
}
