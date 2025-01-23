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
using System.Security.Cryptography.X509Certificates;
namespace UygulamaDenemesi
{
    // LÝSTBOXLARI BÝR DÝZÝ HALÝNE GETÝRÝP ÝÞLEM YAP.
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
        ListBox[]ListBoxKartlar() // Kartlarý Oluþturduk
        {
        ListBox [] ListKartlar = { listKart1, listKart2, listKart3, listKart4, listKart5 };
        return ListKartlar;

        }
        Button[] btnKartLar()// Kartlarýn Buttonlarýný oluþturduk 
        {
            Button[] btnKartlar = { btnKart1, btnKart2, btnKart3, btnKart4, btnKart5 };
            return btnKartlar;
        }
        public UygulumaCalismaKodlarý()
        {
            InitializeComponent();
           
            VisibilityForStart(false);
            string[] Sayilar = new string[] { "0", "1", "2", " 3", " 4", " 5", " 6", " 7", " 8", " 9" };
            lblSayilar.Text = String.Join("    ", Sayilar); // DÝZÝYÝ BÝRLEÞTÝRÝP LABEL EKLEDÝK

        }
        private const int MaxDiziDegeri = 10; // MAKSÝMUM DÝZÝ DEÐERÝ
        // GEREKLÝ DÝZÝLER OLUÞTURULDU:
        
        public int[] DiziInputListbox = new int[MaxDiziDegeri];// Deðer Girdiðimiz Sayýlarý Tutan Dizi
        int[] DiziKontrolListbox = new int[MaxDiziDegeri];// Rastgele Sayýlardan oluþan Dizi
        int SayacUretilenSayi = 0;
        private void btnUretimiBaslat_Click(object sender, EventArgs e)
        {
            btnUretimiBaslat.Visible = false;

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
            BarHýz.Start(); // TÝMER1 baþlatýldý
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
                BarHýz.Stop();
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

        Random RandomSayýUretici = new Random();
        void ChooseBtn()
        {
            if (btnKart1.Enabled == true)
            {
                MessageBox.Show("Button1 e basýldý");
            }
            else if(btnKart2.Enabled == true)
            {
                MessageBox.Show("Button 2 e basýldý");
            }
        }
        public void LotoKartlarýUretimi() // KART URETÝMÝ
        {
            for (int i = 0; i < 10; i++)
            {
                int kart1 = RandomSayýUretici.Next(10);
                int kart2 = RandomSayýUretici.Next(10);
                int kart3 = RandomSayýUretici.Next(10);
                int kart4 = RandomSayýUretici.Next(10);
                int kart5 = RandomSayýUretici.Next(10);
                listKart1.Items.Add((i + 1) + "-" + kart1);
                listKart2.Items.Add((i + 1) + "-" + kart2);
                listKart3.Items.Add((i + 1) + "-" + kart3);
                listKart4.Items.Add((i + 1) + "-" + kart4);
                listKart5.Items.Add((i + 1) + "-" + kart5);
            }
        }
        public void KartlarýTemizle(ListBox[] KartlarýTemizle) // KARTLARIN TEMÝZLENMESÝ
        {
        for(int i = 0; i < KartlarýTemizle.Length; i++)
            {
                KartlarýTemizle[i].Items.Clear();
            }
        }
        void btnKartVisible(Button[] btnkart,bool bDeger)
        {
            for( int i = 0;i < btnkart.Length; i++)
            {
                btnkart[i].Visible = bDeger;
            }
        }
        void listBoxKartVisible(ListBox[] Listkartlar,bool bDeger,int sayi) // Kartlarýn Gözükme Durumu Kontrolu
        {
            for(int i = 0;i<Listkartlar.Length;i++) // Tüm Kartlarý Geziyoruz
            {
                if (sayi == i) // Gözükmesini istediðimiz kartýn Durumunu Deðiþtirmiyoruz 
                {
                    continue;
                }
                Listkartlar[i].Visible = bDeger; // Kartlarýn Gözükmemesini Saðlama
            }
        }
        // KARTLARIN ÝÇÝNDEKÝ DEÐERLERÝ DEÐÝÞTÝRÝYORUZ
        int KartDegisClickSayac = 0;
        void btnKartDegis_Click(object sender, EventArgs e) 
        {
            if (KartDegisClickSayac == 0)
            {
                LotoKartlarýUretimi();
                btnKartVisible(btnKartLar(),true);
                KartDegisClickSayac++;
                return;
            }
            if (KartDegisClickSayac == 1)
            {
                KartlarýTemizle(ListBoxKartlar());
                btnKartVisible(btnKartLar(), false);
                KartDegisClickSayac--;
                return;
            }
        }
        // KARTLARIN BUTTONLARINA BASILDIÐINDA OLMASINI ÝSTEDÝÐÝMÝZ KODLAR:
        private void btnKart1_Click(object sender, EventArgs e)
        {
            btnKart1.Enabled = true;
            ChooseBtn();
            btnKartVisible(btnKartLar(),false);
            listBoxKartVisible(ListBoxKartlar(),false,0);
        }
        private void btnKart2_Click(object sender, EventArgs e)
        {
            btnKart1.Enabled=false;
            btnKart2.Enabled = true;
            ChooseBtn();
            btnKartVisible(btnKartLar(),false);
            listBoxKartVisible(ListBoxKartlar(), false, 1);
        }
        private void btnKart3_Click(object sender, EventArgs e)
        {
            btnKart3.Enabled = true;
            ChooseBtn();
            btnKartVisible(btnKartLar(),false);
            listBoxKartVisible(ListBoxKartlar(), false, 2);
        }
        private void btnKart4_Click(object sender, EventArgs e)
        {
            btnKart4.Enabled = true;
            ChooseBtn();
            btnKartVisible(btnKartLar(),false);
            listBoxKartVisible(ListBoxKartlar(), false, 3);
        }
        private void btnKart5_Click(object sender, EventArgs e)
        {
            btnKart5.Enabled = true;
            ChooseBtn();
            btnKartVisible(btnKartLar(),false);
            listBoxKartVisible(ListBoxKartlar(), false, 4);
        }
    }
}