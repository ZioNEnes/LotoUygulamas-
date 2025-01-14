using Microsoft.VisualBasic.Devices;
using System.Media;
using NAudio.Wave;
using System.Diagnostics.Eventing.Reader;
using System.Web;
using System.Linq.Expressions;
using System.Drawing.Design;
using LotoUygulamasý;
using System.Configuration;
using System.Windows.Forms;
namespace UygulamaDenemesi
{
    // DÝZÝLERÝ KARÞILAÞTIRIP DURUMA GÖRE NE YAPILMASI GEREKTÝÐÝ ÝLE ÝLGÝLENÝLECEK
    // TASARIMSAL ÝYÝLEÞTÝRMELER YAPILACAK:
    // (OYUNDAN ÝSTEDÝÐÝMÝZDE ÇIKABÝLMELÝYÝZ(Close Fonksiyonu sadece oldugu formu kapatýyo Application.Exit) )
    // otomatik eklemeyi çalýþtýrmadan önce kaç saniyede bir oluþturmak istediðini soracaðým
    // Baþlatmadan önce listesini kontrol etmesini,devam edip etmek istemediðini soracaðým
    // MENU TASARIMINA KURALLAR BÖLÜMÜ EKLENÝLECEK
    // DAHA FARKLI OLARAK RASTGELE ELEMANLI LOT KARTLARI OLUÞTURUCAM O KARTLA DEVAM EDÝLECEK:
    public partial class UygulumaCalismaKodlarý : Form
    {
        void VisibilityForStart(bool f) // BAÞLANGIÇTA GÖZÜKMEMESÝ GEREKENLER; 
        {
            btnUretimiBaslat.Visible = f;
            lblRandom.Visible = f;
            lblSayilar.Visible = f;
            lblRandom.Visible = f;
            progressBar.Visible = f;
            listBox1.Visible = f;
        }
            public UygulumaCalismaKodlarý()
        {
            InitializeComponent();
            VisibilityForStart(false);
            string[] Sayilar = new string[] { "0", "1", "2", " 3", " 4", " 5", " 6", " 7", " 8", " 9" };
            lblSayilar.Text = String.Join("    ", Sayilar); // DÝZÝYÝ BÝRLEÞTÝRÝP LABEL EKLEDÝK
            
        }
        private const int MaxDiziDegeri = 10; // MAKSÝMUM DÝZÝ DEÐERÝ
        int SayacUretilenSayi = 0;
        private void btnUretimiBaslat_Click(object sender, EventArgs e)
        {
            btnUretimiBaslat.Visible=false;

            if (SayacUretilenSayi == 9)
            {
                btnUretimiBaslat.Text = "Sonucu Görüntüle";
            }
            if (SayacUretilenSayi == 10) 
            {
                PrintAfterCheck();
                // TEKRAR OYNA BUTONU GÖZÜKECEK
                return;

            }
            Timer1.Start(); // TÝMER1 baþlatýldý
            ReelTime.Start();// ReelTime Baþlatýldý
            SayacUretilenSayi++;
        }
        bool UlastiMi = true; // Barýn artma veya azalma durumunu belirler.
        private void Timer1_Tick(object sender, EventArgs e)//Zamanlayýcý Bar'ýn Çalýþmasý
        {
            if (UlastiMi) // Barýn DURUMU TRUE ÝSE:
            {
                progressBar.Value += 1; // Barýn deðeri artýyor.
                if (progressBar.Value >= progressBar.Maximum)
                {
                    UlastiMi = false; // Maksimum noktaya ulaþýnca azalmaya geç.
                }
            }
            else
            {
                progressBar.Value -= 1; // Barýn deðeri azalýyor.
                if (progressBar.Value <= progressBar.Minimum)
                {
                    UlastiMi = true; // Minimimum noktaya ulaþýnca artmaya geç.
                }
            }
        }
        void btnInputVisibility() // 10 tane sayý girildiði zaman Visibility Durumu:
        {
            btnInput.Visible = false;
            txtInput.Visible = false;
            lblDegerInput.Visible = false;
            btnUretimiBaslat.Visible = true;
            lblRandom.Visible = true;
            lblSayilar.Visible = true;
            lblRandom.Visible = true;
            progressBar.Visible = true;
            listBox1.Visible = true;
        }
        int SayacInput = 0;
        int[] DiziInputListbox = new int[MaxDiziDegeri]; 
        private void btnInput_Click(object sender, EventArgs e)
        {
            int Deger = 0;
            // HATALI DEÐER GÝRÝLMESÝ DURUMUNDA NE YAPILMASI GEREKTÝÐÝ ÝLE ÝLGÝLÝ  KULLANICI BÝLGÝLENDÝLÝRÝR
            try
            {
                Deger = Convert.ToInt32(txtInput.Text);
                if (Deger < 0 || Deger > 10) // Girilen Deðer 0 ile 9 arasýnda olmalýdýr
                {
                    MessageBox.Show("Lütfen 0 ile 9 arasýnda bir deðer giriniz.");
                    txtInput.Clear(); // txt boþaltýldý
                    return; // Kodun Devam etmesi istenilmiyor
                }
            }
            catch (FormatException) // ÝNT'DEN BAÞKA BÝR DEÐER GÝRÝLMESÝ DURUMUNDA KULLANICI BÝLGÝLENDÝRÝLÝR
            {
                txtInput.Clear(); // txt boþaltýldý
                MessageBox.Show("Lütfen 0 ile 9 arasýnda bir tam sayý giriniz.HARF GÝRÝLMEMELÝ!!");
                return;// Kodun Devam etmesi istenilmiyor
            }
            DiziInputListbox[SayacInput] = Deger; // Diziye Girdigimiz Degeri ekliyoruz
            SayacInput++; // Dizinin Ýndeks Deðeri
            txtInput.Clear(); // txt Boþaltýldý
            listBoxEkleme.Items.Add(SayacInput + "-" + Deger);  // listboxa Girdðimiz deðerler eklendi
            if (SayacInput == 10) //  10'adet sayý girilince Gözüküp gözükmemesi gerekenler.
            {
                btnInputVisibility();
            }
        }
        // 5 Saniyede bir Kontrol-Listboxa Eleman Ekliyoruz:
        int[] DiziKontrolListbox = new int[MaxDiziDegeri]; // (Kontrol Lisbox)
        int SayacReelTime = 0; // Gerçek Hayatta Geçen Süreyi tutan sayaç
        int SayacReelTimeBarValue = 0; 
        private void ReelTime_Tick(object sender, EventArgs e)
        {
            if (SayacReelTime == 5) // Sayac 5 e Ulaþtýðýnda
            {
                DiziKontrolListbox[SayacReelTimeBarValue] = progressBar.Value; // BAR2 nin Deðeri Diziye atandý
                SayacReelTime = 0;
                SayacReelTimeBarValue++;
                listBox1.Items.Add(SayacReelTimeBarValue + "-" + progressBar.Value);
                Timer1.Stop();
                ReelTime.Stop();
                btnUretimiBaslat.Visible = true;
            }
            SayacReelTime++;
        }
        int CheckSystem() // Dizileri karþýlaþtýrýp eþleþen sayýsýnýný döndürür
        {
            int CheckSayac = 0;
            for (int i = 0; i < MaxDiziDegeri; i++)
            {
                if (DiziInputListbox[i] == DiziKontrolListbox[i])
                {
                    CheckSayac += 1;
                }
            }
            return CheckSayac;
        }
        void PrintAfterCheck() // LOTODAN NE KADAR PARA KAZANDINIZ:
        {
            switch (CheckSystem())
            {
                case 1:
                    MessageBox.Show("Bu þansla sakýn bilet almayýn!");
                    break;
                case 2:
                    MessageBox.Show("Lotodan yüzde 5  kazandýnýz TEBRÝKLER");
                    break;
                case 3:
                    MessageBox.Show("Lotodan yüzde 10  kazandýnýz TEBRÝKLER");
                    break;
                default:
                    MessageBox.Show("Bu þansla sakýn bilet almayýn!");
                    break;
            }
        }
        private void btnOyunuKapatForm_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayý direkt kapat
        }
    }
}