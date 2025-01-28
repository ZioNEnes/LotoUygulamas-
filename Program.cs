using LotoUygulamasý;

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
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu_Tasarim());
        }
    }
}