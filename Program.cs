using LotoUygulamas�;

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