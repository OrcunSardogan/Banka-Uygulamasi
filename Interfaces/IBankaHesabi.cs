namespace BankaUygulamasi.Interfaces
{
    public interface IBankaHesabi
    {
        string ?hesapNo { get; set; }
        int bakiye { get; set; }
        void ParaYatir(int miktar);
        void ParaCek(int miktar);
        void Transfer(Models.BankaHesabi hedefhesap, int miktar);
        void BakiyeYazdir();
        void GecmisYazdir();
    }
}
