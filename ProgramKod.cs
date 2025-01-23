using Microsoft.VisualBasic.Devices;
using System.Media;
using NAudio.Wave;
using System.Diagnostics.Eventing.Reader;
using System.Web;
using System.Linq.Expressions;
using System.Drawing.Design;
using LotoUygulamas�;
using System.Configuration;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
namespace UygulamaDenemesi
{
    // L�STBOXLARI B�R D�Z� HAL�NE GET�R�P ��LEM YAP.
    // D�Z�LER� KAR�ILA�TIRIP DURUMA G�RE NE YAPILMASI GEREKT��� �LE �LG�LEN�LECEK
    // TASARIMSAL �Y�LE�T�RMELER YAPILACAK:
    // (OYUNDAN �STED���M�ZDE �IKAB�LMEL�Y�Z(Close Fonksiyonu sadece oldugu formu kapat�yo Application.Exit) )
    // otomatik eklemeyi �al��t�rmadan �nce ka� saniyede bir olu�turmak istedi�ini soraca��m
    // Ba�latmadan �nce listesini kontrol etmesini,devam edip etmek istemedi�ini soraca��m
    // MENU TASARIMINA KURALLAR B�L�M� EKLEN�LECEK
    // DAHA FARKLI OLARAK RASTGELE ELEMANLI LOT KARTLARI OLU�TURUCAM O KARTLA DEVAM ED�LECEK:
    public partial class UygulumaCalismaKodlar� : Form
    {
        void VisibilityForStart(bool f) // BA�LANGI�TA G�Z�KMEMES� GEREKENLER; 
        {
            btnUretimiBaslat.Visible = f;
            lblRandom.Visible = f;
            lblSayilar.Visible = f;
            lblRandom.Visible = f;
            progressBar.Visible = f;
            listBox1.Visible = f;
        }
        ListBox[]ListBoxKartlar() // Kartlar� Olu�turduk
        {
        ListBox [] ListKartlar = { listKart1, listKart2, listKart3, listKart4, listKart5 };
        return ListKartlar;

        }
        Button[] btnKartLar()// Kartlar�n Buttonlar�n� olu�turduk 
        {
            Button[] btnKartlar = { btnKart1, btnKart2, btnKart3, btnKart4, btnKart5 };
            return btnKartlar;
        }
        public UygulumaCalismaKodlar�()
        {
            InitializeComponent();
           
            VisibilityForStart(false);
            string[] Sayilar = new string[] { "0", "1", "2", " 3", " 4", " 5", " 6", " 7", " 8", " 9" };
            lblSayilar.Text = String.Join("    ", Sayilar); // D�Z�Y� B�RLE�T�R�P LABEL EKLED�K

        }
        private const int MaxDiziDegeri = 10; // MAKS�MUM D�Z� DE�ER�
        // GEREKL� D�Z�LER OLU�TURULDU:
        
        public int[] DiziInputListbox = new int[MaxDiziDegeri];// De�er Girdi�imiz Say�lar� Tutan Dizi
        int[] DiziKontrolListbox = new int[MaxDiziDegeri];// Rastgele Say�lardan olu�an Dizi
        int SayacUretilenSayi = 0;
        private void btnUretimiBaslat_Click(object sender, EventArgs e)
        {
            btnUretimiBaslat.Visible = false;

            if (SayacUretilenSayi == 9)
            {
                btnUretimiBaslat.Text = "Sonucu G�r�nt�le";
            }
            if (SayacUretilenSayi == 10)
            {
                PrintAfterCheck();
                // TEKRAR OYNA BUTONU G�Z�KECEK
                return;

            }
            BarH�z.Start(); // T�MER1 ba�lat�ld�
            ReelTime.Start();// ReelTime Ba�lat�ld�
            SayacUretilenSayi++;
        }
        bool UlastiMi = true; // Bar�n artma veya azalma durumunu belirler.
        private void Timer1_Tick(object sender, EventArgs e)//Zamanlay�c� Bar'�n �al��mas�
        {
            if (UlastiMi) // Bar�n DURUMU TRUE �SE:
            {
                progressBar.Value += 1; // Bar�n de�eri art�yor.
                if (progressBar.Value >= progressBar.Maximum)
                {
                    UlastiMi = false; // Maksimum noktaya ula��nca azalmaya ge�.
                }
            }
            else
            {
                progressBar.Value -= 1; // Bar�n de�eri azal�yor.
                if (progressBar.Value <= progressBar.Minimum)
                {
                    UlastiMi = true; // Minimimum noktaya ula��nca artmaya ge�.
                }
            }
        }
        void btnInputVisibility() // 10 tane say� girildi�i zaman Visibility Durumu:
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
            // HATALI DE�ER G�R�LMES� DURUMUNDA NE YAPILMASI GEREKT��� �LE �LG�L�  KULLANICI B�LG�LEND�L�R�R
            try
            {
                Deger = Convert.ToInt32(txtInput.Text);
                if (Deger < 0 || Deger > 10) // Girilen De�er 0 ile 9 aras�nda olmal�d�r
                {
                    MessageBox.Show("L�tfen 0 ile 9 aras�nda bir de�er giriniz.");
                    txtInput.Clear(); // txt bo�alt�ld�
                    return; // Kodun Devam etmesi istenilmiyor
                }
            }
            catch (FormatException) // �NT'DEN BA�KA B�R DE�ER G�R�LMES� DURUMUNDA KULLANICI B�LG�LEND�R�L�R
            {
                txtInput.Clear(); // txt bo�alt�ld�
                MessageBox.Show("L�tfen 0 ile 9 aras�nda bir tam say� giriniz.HARF G�R�LMEMEL�!!");
                return;// Kodun Devam etmesi istenilmiyor
            }
            DiziInputListbox[SayacInput] = Deger; // Diziye Girdigimiz Degeri ekliyoruz
            SayacInput++; // Dizinin �ndeks De�eri
            txtInput.Clear(); // txt Bo�alt�ld�
            listBoxEkleme.Items.Add(SayacInput + "-" + Deger);  // listboxa Gird�imiz de�erler eklendi
            if (SayacInput == 10) //  10'adet say� girilince G�z�k�p g�z�kmemesi gerekenler.
            {
                btnInputVisibility();
            }
        }
        // 5 Saniyede bir Kontrol-Listboxa Eleman Ekliyoruz:

        int SayacReelTime = 0; // Ger�ek Hayatta Ge�en S�reyi tutan saya�
        int SayacReelTimeBarValue = 0;
        private void ReelTime_Tick(object sender, EventArgs e)
        {
            if (SayacReelTime == 5) // Sayac 5 e Ula�t���nda
            {
                DiziKontrolListbox[SayacReelTimeBarValue] = progressBar.Value; // BAR2 nin De�eri Diziye atand�
                SayacReelTime = 0;
                SayacReelTimeBarValue++;
                listBox1.Items.Add(SayacReelTimeBarValue + "-" + progressBar.Value);
                BarH�z.Stop();
                ReelTime.Stop();
                btnUretimiBaslat.Visible = true;
            }
            SayacReelTime++;
        }
        int CheckSystem() // Dizileri kar��la�t�r�p e�le�en say�s�n�n� d�nd�r�r
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
                    MessageBox.Show("Lotodan y�zde 5  kazand�n�z TEBR�KLER");
                    break;
                case 3:
                    MessageBox.Show("Lotodan y�zde 10  kazand�n�z TEBR�KLER");
                    break;
                default:
                    MessageBox.Show("Bu �ansla sak�n bilet almay�n!");
                    break;
            }
        }
        private void btnOyunuKapatForm_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamay� direkt kapat
        }

        Random RandomSay�Uretici = new Random();
        void ChooseBtn()
        {
            if (btnKart1.Enabled == true)
            {
                MessageBox.Show("Button1 e bas�ld�");
            }
            else if(btnKart2.Enabled == true)
            {
                MessageBox.Show("Button 2 e bas�ld�");
            }
        }
        public void LotoKartlar�Uretimi() // KART URET�M�
        {
            for (int i = 0; i < 10; i++)
            {
                int kart1 = RandomSay�Uretici.Next(10);
                int kart2 = RandomSay�Uretici.Next(10);
                int kart3 = RandomSay�Uretici.Next(10);
                int kart4 = RandomSay�Uretici.Next(10);
                int kart5 = RandomSay�Uretici.Next(10);
                listKart1.Items.Add((i + 1) + "-" + kart1);
                listKart2.Items.Add((i + 1) + "-" + kart2);
                listKart3.Items.Add((i + 1) + "-" + kart3);
                listKart4.Items.Add((i + 1) + "-" + kart4);
                listKart5.Items.Add((i + 1) + "-" + kart5);
            }
        }
        public void Kartlar�Temizle(ListBox[] Kartlar�Temizle) // KARTLARIN TEM�ZLENMES�
        {
        for(int i = 0; i < Kartlar�Temizle.Length; i++)
            {
                Kartlar�Temizle[i].Items.Clear();
            }
        }
        void btnKartVisible(Button[] btnkart,bool bDeger)
        {
            for( int i = 0;i < btnkart.Length; i++)
            {
                btnkart[i].Visible = bDeger;
            }
        }
        void listBoxKartVisible(ListBox[] Listkartlar,bool bDeger,int sayi) // Kartlar�n G�z�kme Durumu Kontrolu
        {
            for(int i = 0;i<Listkartlar.Length;i++) // T�m Kartlar� Geziyoruz
            {
                if (sayi == i) // G�z�kmesini istedi�imiz kart�n Durumunu De�i�tirmiyoruz 
                {
                    continue;
                }
                Listkartlar[i].Visible = bDeger; // Kartlar�n G�z�kmemesini Sa�lama
            }
        }
        // KARTLARIN ���NDEK� DE�ERLER� DE���T�R�YORUZ
        int KartDegisClickSayac = 0;
        void btnKartDegis_Click(object sender, EventArgs e) 
        {
            if (KartDegisClickSayac == 0)
            {
                LotoKartlar�Uretimi();
                btnKartVisible(btnKartLar(),true);
                KartDegisClickSayac++;
                return;
            }
            if (KartDegisClickSayac == 1)
            {
                Kartlar�Temizle(ListBoxKartlar());
                btnKartVisible(btnKartLar(), false);
                KartDegisClickSayac--;
                return;
            }
        }
        // KARTLARIN BUTTONLARINA BASILDI�INDA OLMASINI �STED���M�Z KODLAR:
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