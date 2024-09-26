# Türkiye Cumhuriyeti Vatandaşlık Doğrulama Programı

Bu proje, Türkiye Cumhuriyeti vatandaşlık numaralarını doğrulamak için kullanılan bir C# uygulamasıdır. Uygulama, Nüfus ve Vatandaşlık İşleri Genel Müdürlüğü'nün sunduğu KPSPublic SOAP servisini kullanarak vatandaşlık doğrulaması yapar.

## Özellikler

- Türkiye Cumhuriyeti vatandaşlık numarası (T.C. Kimlik No) doğrulama.
- KPSPublic SOAP servisini kullanarak gerçek zamanlı vatandaşlık doğrulaması.
- Kullanıcı girdilerinin geçerliliğini kontrol etmek için ErrorProvider ile hata kontrolü.
- Doğrulama süreci sırasında kullanıcıya bir yükleniyor (loading) paneli gösterimi.

## Kullanılan Teknolojiler

- **C#**: Ana programlama dili.
- **DevExpress**: Form elemanları ve hata sağlayıcı (DXErrorProvider) için kullanılan kütüphane.
- **KPSPublic SOAP Servisi**: Türkiye Cumhuriyeti vatandaşlık numarasını doğrulamak için kullanılan servis.
- **.NET Framework**: Proje .NET Framework üzerinde geliştirilmiştir.

## Kurulum ve Kullanım

### Gereksinimler

- Visual Studio 2019 veya üstü.
- .NET Framework 4.7.2 veya üstü.
- DevExpress bileşenlerinin yüklü olması (Deneme sürümü ya da lisanslı versiyon kullanılabilir).
- KPSPublic SOAP servisine erişim için gerekli bağlantı bilgileri.

### Projeyi Çalıştırma Adımları

1. **Projeyi Klonlayın:**

   ```bash
   git clone https://github.com/htunc29/tc-vatandaslik-dogrulama.git
   cd tc-vatandaslik-dogrulama
