using BankaUygulamasi.Interfaces;

namespace BankaUygulamasi.Models
{
    public class BankaHesabi : IBankaHesabi
    {
        public string ?hesapNo { get; set; }
        public int bakiye { get; set; }
        public List<string> gecmis = new List<string>();

        public BankaHesabi(string hesapNo, int bakiye)
        {
            this.hesapNo = hesapNo;
            this.bakiye = bakiye;
            gecmis.Add($"{DateTime.Now}: Hesap oluşturuldu, başlangıç bakiyesi {bakiye} TL");
        }

        public void ParaYatir(int miktar)
        {
            if (miktar > 0)
            {
                bakiye += miktar;
                gecmis.Add($"{DateTime.Now}: {miktar} TL yatırıldı");
                Console.WriteLine($"{miktar} TL hesabınıza yatırıldı");
                return;
            }
            Console.WriteLine("Geçerli bir miktar giriniz");
        }

        public void ParaCek(int miktar)
        {
            if (miktar > 0 && miktar <= bakiye)
            {
                bakiye -= miktar;
                gecmis.Add($"{DateTime.Now}: {miktar} TL çekildi");
                Console.WriteLine($"{miktar} TL hesabınızdan çekildi");
                return;
            }
            Console.WriteLine("Yetersiz bakiye veya geçersiz miktar");
        }

        public void Transfer(BankaHesabi hedefhesap, int miktar)
        {
            if (miktar <= 0)
            {
                Console.WriteLine("Geçerli bir miktar giriniz");
                return;
            }
            else if (miktar <= bakiye)
            {
                bakiye -= miktar;
                hedefhesap.bakiye += miktar;
                gecmis.Add($"{DateTime.Now}: {hedefhesap.hesapNo} numaralı hesaba {miktar} TL transfer edildi");
                hedefhesap.gecmis.Add($"{DateTime.Now}: {hesapNo} numaralı hesaptan {miktar} TL transfer alındı");
                Console.WriteLine($"{miktar} TL {hedefhesap.hesapNo} numaralı hesaba transfer edildi");
                return;
            }
            Console.WriteLine("Yetersiz bakiye");
        }

        public void BakiyeYazdir()
        {
            Console.WriteLine($"{hesapNo} Numaralı hesabın bakiyesi: {bakiye} TL");
        }

        public void GecmisYazdir()
        {
            Console.WriteLine($"{hesapNo} numaralı hesabın işlem geçmişi:");
            foreach (var i in gecmis)
            {
                Console.WriteLine("* " + i);
            }
        }
    }
}
