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
using static System.Windows.Forms.DataFormats;
using NAudio.CoreAudioApi;
namespace UygulamaDenemesi
{
    public partial class UygulumaCalismaKodlarý : Form
    {
        // public static UygulumaCalismaKodlarý instance; // Formun Global örneði
        void VisibilityForStart(bool f) // BAÞLANGIÇTA GÖZÜKMEMESÝ GEREKENLER; 
        {
            btnKartVisible(btnKartLar(),f);
            btnUretimiBaslat.Visible = f;
            lblRandom.Visible = f;
            lblSayilar.Visible = f;
            lblRandom.Visible = f;
            progressBar.Visible = f;
            listBox1.Visible = f;
        }
        ListBox[] ListBoxKartlar() // Kartlarý Oluþturduk
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
           // instance = this;
            VisibilityForStart(false);
            string[] Sayilar = new string[] { "0", "1", "2", " 3", " 4", " 5", " 6", " 7", " 8", " 9" };
            lblSayilar.Text = String.Join("    ", Sayilar); // DÝZÝYÝ BÝRLEÞTÝRÝP LABEL EKLEDÝK

        }
        private const int MaxDiziDegeri = 10; // MAKSÝMUM DÝZÝ DEÐERÝ
        // GEREKLÝ DÝZÝLER OLUÞTURULDU:
        
        public int[] DiziInputListbox = new int[MaxDiziDegeri];// Deðer Girdiðimiz Sayýlarý Tutan Dizi
        int[] kartRastgeleSayilar = new int[50]; // Bütün Rastgele Sayýlarý Tutan Dizi
        int[] DiziKontrolListbox = new int[MaxDiziDegeri];// Rastgele Sayýlardan oluþan Dizi
        int SayacUretilenSayi = 0; // UretimiBaslat Buttonuna týklama Sayisi
        int BaslangicDeger = 0;
        int BitisDeger = 1;
        private void btnUretimiBaslat_Click(object sender, EventArgs e)
        {

            btnUretimiBaslat.Visible = false; // Buttona Bastýkça Tekrar Basýlmamasý için Gizledik

            if (SayacUretilenSayi == 9)
            {
                btnUretimiBaslat.Text = "Sonucu Görüntüle";
            }
            if (SayacUretilenSayi == 10) // Buttona 10 kere týklarsak  
            {
                PrintAfterCheck(BaslangicDeger,BitisDeger); //  
                // TEKRAR OYNA BUTONUNU BU SATIRDA GÖZÜKMESÝNÝ SAÐLAYACAÐIZ
                return;

            }
            BarHýz.Start(); // TÝMER1 baþlatýldý
            ReelTime.Start();// ReelTime Baþlatýldý
            SayacUretilenSayi++;// Buttona týklama sayisini týkladýkça Deðiþ
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
        public void btnInputVisibilityORClickBtnKart() // 10 tane sayý girildiði ya da Kart seçildiði zaman Visibility Durumu:
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
                btnInputVisibilityORClickBtnKart(); // Gözükme durumu deðiþmesi gereken önemli unsurlarý deðiþtir 
            }
        }
        // 5 Saniyede bir Kontrol-Listboxa Eleman Ekliyoruz:
       private int SayacReelTime = 0; // Gerçek Hayatta Geçen Süreyi tutan sayaç
       private int SayacReelTimeBarValue = 0;
        private void ReelTime_Tick(object sender, EventArgs e) // Her 1 Saniye geçen sürede çalýþtýr
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
        // CheckSystem FONKSÝYONU (Dizileri karþýlaþtýrýp eþleþen sayýsýnýný döndür)
        int CheckSystem(int Baslangic,int Bitis) 
        {
            int CheckSayac = 0; // EþleþenSayisi Deðiþkeni
            int k = 0;
            for (int i = Baslangic; i < Bitis; i++,k++)
            {
                if (kartRastgeleSayilar[i] == DiziKontrolListbox[k]) // Dizileri Kontrol et 
                {
                    CheckSayac += 1; // Dizide Eþleþme Durumu Varsa Deðeri Arttýr
                }
            }
            return CheckSayac; // Eþleþen Sayisini Döndür
        }
        // PrinAfterCheck FONKSÝYONU (LOTODAN NE KADAR PARA KAZANDINIZ:)
        void PrintAfterCheck(int BaslangicAl,int BitisAl)
        {
            switch (CheckSystem(BaslangicAl,BitisAl))
            {
                case 2:
                    MessageBox.Show("Lotodan yüzde 20  kazandýnýz TEBRÝKLER");
                    break;
                case 3:
                    MessageBox.Show("Lotodan yüzde 30  kazandýnýz TEBRÝKLER");
                    break;
                case 4:
                    MessageBox.Show("Lotodan yüzde 40  kazandýnýz TEBRÝKLER");
                    break;
                default:
                    MessageBox.Show("Bu þansla sakýn bilet almayýn!");
                    break;
            }
        }
        Random RandomSayýUretici = new Random();
        int[] kartRastgeleSayi = new int[10];
        public void LotoKartlarýUretimi(ListBox[] Kart) // Rastgele Sayýlarda KART URETÝMÝ
        {
            int Toplam10Eleman = 0;
            int T10 = Toplam10Eleman;
            int NeredenBaþladýgýnýBul = 0;
            int NBB = NeredenBaþladýgýnýBul;
            for (int j = 0; j < 5; j++) // Kartlara Göre iþlem Toplam 5 kere
                {
                    for (int i = 0; i < 10; i++) // Kartlarýn Ýçini Doldurma
                    {
                    kartRastgeleSayi[i] = RandomSayýUretici.Next(10); // Rastgele sayiyi ATA
                    Kart[j].Items.Add((i + 1) + "-" + kartRastgeleSayi[i]); //Listboxa ekle
                }
                for(int k = NBB; k < 50; k++, T10++,NBB++) // Dizinin Tüm elemanlarýný Rastgele Doldur         
                        {
                        kartRastgeleSayilar[k] = kartRastgeleSayi[T10];

                            if (NBB == 9 || NBB == 19 || NBB == 29 || NBB == 39 || NBB == 49)
                                {
                                  break;
                                }
                        }
                T10 = 0;  
                  NBB++;
                }
        }
        public void KartlarýTemizle(ListBox[] KartlarýTemizle) // KARTLARIN TEMÝZLENMESÝ
        {
        for(int i = 0; i < KartlarýTemizle.Length; i++)
            {
                KartlarýTemizle[i].Items.Clear();
            }
        }
        void btnKartVisible(Button[] btnkart,bool bDeger) // Btn Kartlarýn Gözükme Durumu Kontrolu
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
        private void btnKartDegis_Click(object sender, EventArgs e) 
        {
            if (KartDegisClickSayac == 0)
            {
                btnKartDegis.Text = "Temizle";
                LotoKartlarýUretimi(ListBoxKartlar());
                btnKartVisible(btnKartLar(),true);
                KartDegisClickSayac++;
                return;
            }
            if (KartDegisClickSayac == 1)
            {
                btnKartDegis.Text = "Sayilarý Oluþtur";
                KartlarýTemizle(ListBoxKartlar());
                btnKartVisible(btnKartLar(), false);
                KartDegisClickSayac--;
                return;
            }
        }
        // KARTLARIN BUTTONLARINA BASILDIÐINDA OLMASINI ÝSTEDÝÐÝMÝZ KODLAR:
        int Baslangic(int baslangic) // Baslangic Degeri Döndür
        {
            BaslangicDeger = baslangic;
            return BaslangicDeger;
        }
        int Bitis(int bitis) // Bitis Degeri Döndür
        {
            BitisDeger= bitis;
            return BitisDeger;
        }
        private void btnKart1_Click(object sender, EventArgs e)
        {
            btnKartDegis.Visible=false; // Kart Seçildikten sonra Kartýn özelliklerini deðiþtirmememiz için
            Baslangic(0);
            Bitis(10);
            btnKartVisible(btnKartLar(),false); // Diðer Buttonlarýn Gözükmesini Engelle
            listBoxKartVisible(ListBoxKartlar(),false,0); // Diðer ListKartlarýn Gözükmesini Engelle
            btnInputVisibilityORClickBtnKart(); // Gözükme durumu deðiþmesi gereken önemli unsurlarý deðiþtir  
        }
        private void btnKart2_Click(object sender, EventArgs e)
        {
            btnKartDegis.Visible = false; // Kart Seçildikten sonra Kartýn özelliklerini deðiþtirmememiz için
            Baslangic(10);
            Bitis(20);
            btnKartVisible(btnKartLar(),false); // Diðer Buttonlarýn Gözükmesini Engelle
            listBoxKartVisible(ListBoxKartlar(), false, 1); // Diðer ListKartlarýn Gözükmesini Engelle
            btnInputVisibilityORClickBtnKart(); // Gözükme durumu deðiþmesi gereken önemli unsurlarý deðiþtir  
        }
        private void btnKart3_Click(object sender, EventArgs e)
        {
            btnKartDegis.Visible = false; // Kart Seçildikten sonra Kartýn özelliklerini deðiþtirmememiz için
            Baslangic(20);
            Bitis(30);
            btnKartVisible(btnKartLar(),false); // Diðer Buttonlarýn Gözükmesini Engelle
            listBoxKartVisible(ListBoxKartlar(), false, 2); // Diðer ListKartlarýn Gözükmesini Engelle
            btnInputVisibilityORClickBtnKart(); // Gözükme durumu deðiþmesi gereken önemli unsurlarý deðiþtir  
        }
        private void btnKart4_Click(object sender, EventArgs e)
        {
            btnKartDegis.Visible = false; // Kart Seçildikten sonra Kartýn özelliklerini deðiþtirmememiz için
            Baslangic(30);
            Bitis(40);
            btnKartVisible(btnKartLar(),false); // Diðer Buttonlarýn Gözükmesini Engelle
            listBoxKartVisible(ListBoxKartlar(), false, 3); // Diðer ListKartlarýn Gözükmesini Engelle
            btnInputVisibilityORClickBtnKart(); // Gözükme durumu deðiþmesi gereken önemli unsurlarý deðiþtir  
        }
        private void btnKart5_Click(object sender, EventArgs e)
        {
            btnKartDegis.Visible = false; // Kart Seçildikten sonra Kartýn özelliklerini deðiþtirmememiz için
            Baslangic(40);
            Bitis(50);
            btnKartVisible(btnKartLar(),false); // Diðer Buttonlarýn Gözükmesini Engelle
            listBoxKartVisible(ListBoxKartlar(), false, 4); // Diðer ListKartlarýn Gözükmesini Engelle
            btnInputVisibilityORClickBtnKart(); // Gözükme durumu deðiþmesi gereken önemli unsurlarý deðiþtir  
        }
        // Oyunu Kaptma Buttonu
        private void btnOyunuKapatForm_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayý direkt kapat
        }
    }
}