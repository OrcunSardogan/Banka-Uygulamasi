using BankaUygulamasi.Interfaces;
using BankaUygulamasi.Services;
using BankaUygulamasi.UI;

namespace BankaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankaIslemleri bankaIslemi = new BankaIslemleri();
            UygulamaMenu menu = new UygulamaMenu();
            menu.UygulamaCalistir(bankaIslemi);

        }
    }
}
