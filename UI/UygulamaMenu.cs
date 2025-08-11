using BankaUygulamasi.Interfaces;
using BankaUygulamasi.Services;

namespace BankaUygulamasi.UI
{
    public class UygulamaMenu
    {
        public void UygulamaCalistir(IBankaIslemleri islem)
        {
            while (true)
            {
                Console.WriteLine("----- Banka Uygulaması -----");
                Console.WriteLine("1.Hesap Aç");
                Console.WriteLine("2.Para Yatır");
                Console.WriteLine("3.Para Çek");
                Console.WriteLine("4.Bakiye Göster");
                Console.WriteLine("5.Başka Hesaba Para Transferi");
                Console.WriteLine("6.İşlem Geçmişini Görüntüle");
                Console.WriteLine("7.Bütün Hesapları Sıfırla");
                Console.WriteLine("8.Çıkış");
                Console.Write("Seçiminiz: ");

                string ?secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        islem.HesapAc();
                        break;

                    case "2":
                        islem.HesapIslem(h =>
                        {
                            Console.WriteLine("Yatırılacak miktar:");
                            while (true)
                            {
                                int miktar = Convert.ToInt32(Console.ReadLine());
                                if (miktar > 0)
                                {
                                    h.ParaYatir(miktar);
                                    break;
                                }
                                h.ParaYatir(miktar);
                            }
                        });
                        break;

                    case "3":
                        islem.HesapIslem(h =>
                        {
                            Console.WriteLine("Çekilecek miktar:");
                            while (true)
                            {
                                int miktar = Convert.ToInt32(Console.ReadLine());
                                if (miktar > 0 && miktar <= h.bakiye)
                                {
                                    h.ParaCek(miktar);
                                    break;
                                }
                                h.ParaCek(miktar);
                            }
                        });
                        break;

                    case "4":
                        islem.HesapIslem(h => h.BakiyeYazdir());
                        break;

                    case "5":
                        islem.TransferIslemi();
                        break;

                    case "6":
                        islem.HesapIslem(h => h.GecmisYazdir());
                        break;

                    case "7":
                        BankaIslemleri.hesaplar.Clear();
                        Console.WriteLine("Tüm hesaplar silindi");
                        break;

                    case "8":
                        Console.WriteLine("Uygulamadan çıkılıyor...");
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçim");
                        break;
                }
            }
        }
    }
}
