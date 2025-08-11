using BankaUygulamasi.Models;

namespace BankaUygulamasi.Interfaces
{
    public interface IBankaIslemleri
    {
        void HesapAc();
        void HesapIslem(Action<BankaHesabi> islem);
        void TransferIslemi();
    }
}
