using BankaUygulamasi.Interfaces;
using BankaUygulamasi.Models;

namespace BankaUygulamasi.Services
{
    public class BankaIslemleri : IBankaIslemleri
    {
        public static List<BankaHesabi> hesaplar = new List<BankaHesabi>();

        public void HesapAc()
        {
            Console.WriteLine("Yeni hesap numarası giriniz");
            string ?numara = Console.ReadLine();

            if (hesaplar.Any(h => h.hesapNo == numara))
            {
                Console.WriteLine("Bu hesap numarası zaten mevcut");
                return;
            }

            Console.WriteLine("Başlangıç bakiyesi giriniz");
            int bakiye = Convert.ToInt32(Console.ReadLine());

            if (bakiye < 0)
            {
                Console.WriteLine("Geçersiz bakiye");
                return;
            }

            hesaplar.Add(new BankaHesabi(numara=null!, bakiye));
            Console.WriteLine($"{numara} Numaralı hesap oluşturuldu");
        }

        public void HesapIslem(Action<BankaHesabi> islem)
        {
            if (!hesaplar.Any())
            {
                Console.WriteLine("Henüz hesap oluşturulmamış");
                return;
            }

            Console.WriteLine("Hesap numaranızı giriniz");
            string ?numara = Console.ReadLine();

            BankaHesabi ?hesap = hesaplar.FirstOrDefault(h => h.hesapNo == numara);

            if (hesap != null)
            {
                islem(hesap);
            }
            else
            {
                Console.WriteLine("Hesap bulunamadı");
            }
        }

        public void TransferIslemi()
        {
            if (hesaplar.Count < 2)
            {
                Console.WriteLine("En az iki hesap olmalıdır");
                return;
            }

            Console.WriteLine("Gönderen hesap numarasını giriniz");
            string ?gnumara = Console.ReadLine();
            BankaHesabi ?gonderen = hesaplar.FirstOrDefault(h => h.hesapNo == gnumara);

            Console.WriteLine("Alıcı hesap numarasını giriniz");
            string ?anumara = Console.ReadLine();
            BankaHesabi ?alici = hesaplar.FirstOrDefault(h => h.hesapNo == anumara);

            if (gonderen == null || alici == null)
            {
                Console.WriteLine("Hesaplardan biri bulunamadı");
                return;
            }
            else if (gonderen == alici)
            {
                Console.WriteLine("Kendi hesabınıza transfer yapamazsınız");
                return;
            }

            Console.WriteLine("Transfer miktarı:");
            while (true)
            {
                int miktar = Convert.ToInt32(Console.ReadLine());
                if (miktar > 0 && miktar <= gonderen.bakiye)
                {
                    gonderen.Transfer(alici, miktar);
                    break;
                }
                gonderen.Transfer(alici, miktar);
            }
        }
    }
}
