# 🏦 Banka Uygulaması (.NET Console)

Bu proje, **C#** ile yazılmış, konsol tabanlı basit bir **banka yönetim sistemi** uygulamasıdır.  
Kullanıcılar hesap açabilir, para yatırabilir, para çekebilir, bakiye görüntüleyebilir, başka hesaba para transferi yapabilir ve işlem geçmişini görebilir.

---

## 🚀 Özellikler
- 📌 **Hesap Açma**: Yeni banka hesabı oluşturma
- 💰 **Para Yatırma**: Mevcut hesaba para ekleme
- 💸 **Para Çekme**: Hesaptan para çekme
- 🔍 **Bakiye Görüntüleme**: Hesap bakiyesini gösterme
- 🔄 **Hesaplar Arası Transfer**: Farklı hesaplar arasında para transferi
- 📜 **İşlem Geçmişi**: Hesap hareketlerini listeleme
- 🗑 **Tüm Hesapları Sıfırlama**: Sistemdeki tüm hesapları temizleme

---

## 📂 Proje Yapısı
BankaUygulamasi/
│
├── Program.cs # Uygulama başlangıç noktası
│
├── Interfaces/ # Arayüz tanımları
│ ├── IBankaHesabi.cs
│ └── IBankaIslemleri.cs
│
├── Models/ # Veri modelleri
│ └── BankaHesabi.cs
│
├── Services/ # İş mantığı
│ └── BankaIslemleri.cs
│
├── UI/ # Kullanıcı arayüzü (konsol)
│ └── UygulamaMenu.cs
│
└── Helpers/ # Yardımcı sınıflar
└── StaticClass.cs

---

## 🛠 Kurulum ve Çalıştırma

1. **Projeyi klonlayın**
   ```bash
   git clone https://github.com/kullaniciadi/BankaUygulamasi.git
   cd BankaUygulamasi
2. **Bağımlılıkları yükleyin/derleyin**
   ```bash
   dotnet build

 3.**Uygulamayı Çalıştırın**
   ```bash
   dotnet run
