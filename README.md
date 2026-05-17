# BabyCare - Çocuk Bakım ve Eğitim Merkezi Web Sitesi

<div align="center">
  <h3>Modern, Responsive ve Kullanıcı Dostu Çocuk Bakım Merkezi Web Uygulaması</h3>
  
  <p>
    <img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet" alt=".NET 8.0"/>
    <img src="https://img.shields.io/badge/MongoDB-6.0-47A248?style=flat-square&logo=mongodb" alt="MongoDB"/>
    <img src="https://img.shields.io/badge/Bootstrap-5.0-7952B3?style=flat-square&logo=bootstrap" alt="Bootstrap"/>
    <img src="https://img.shields.io/badge/ASP.NET-MVC-purple?style=flat-square" alt="ASP.NET MVC"/>
  </p>
</div>

---

## 📋 İçindekiler

- [Özellikler](#özellikler)
- [Teknolojiler](#teknolojiler)
- [Ekran Görüntüleri](#ekran-görüntüleri)
- [Kurulum](#kurulum)
- [Proje Yapısı](#proje-yapısı)
- [Veritabanı Yapılandırması](#veritabanı-yapılandırması)
- [Kullanım](#kullanım)

---

## ✨ Özellikler

### 🎨 Frontend (Kullanıcı Tarafı)
- ✅ Modern ve responsive tasarım (BabyCare Template)
- ✅ Mobil uyumlu arayüz
- ✅ Video modal desteği
- ✅ Dinamik galeri sistemi
- ✅ Etkinlik takvimi
- ✅ Müşteri yorumları (Testimonials)
- ✅ Öne çıkan alan (Banner/Hero)
- ✅ Eğitmen profilleri
- ✅ Program/Kurs listesi
- ✅ Smooth scroll navigation

### 🔐 Admin Panel
- ✅ Breeze Admin Template
- ✅ CRUD işlemleri (Create, Read, Update, Delete)
- ✅ Responsive admin arayüzü
- ✅ Real-time site önizleme
- ✅ Kullanıcı dostu form validasyonları

### 📦 Modüller
1. **Banner** - Öne çıkan alan/slider yönetimi
2. **About** - Hakkımızda bilgileri ve istatistikler
3. **Service** - Hizmet yönetimi
4. **Product** - Eğitim programları
5. **Event** - Etkinlik yönetimi
6. **Instructor** - Öğretmen profilleri
7. **Testimonial** - Müşteri yorumları
8. **FooterGallery** - Footer galeri
9. **FooterInformation** - İletişim bilgileri
10. **FooterSubscribe** - E-bülten aboneliği

---

## 🛠️ Teknolojiler

### Backend
- **Framework:** ASP.NET Core 8.0 MVC
- **Language:** C# 12
- **Database:** MongoDB 6.0+
- **ORM:** MongoDB.Driver
- **Mapping:** AutoMapper
- **Architecture:** ViewComponent Pattern

### Frontend
- **HTML5 / CSS3**
- **JavaScript / jQuery 3.6.4**
- **Bootstrap 5.0**
- **FontAwesome 5.15.4**
- **Owl Carousel** (Slider)
- **WOW.js** (Animations)
- **Lightbox** (Image Gallery)

### Templates
- **Frontend:** BabyCare-1.0.0 (HTML Codex)
- **Admin:** Breeze Free Bootstrap Admin Template

---

## 📸 Ekran Görüntüleri

### 🌐 Frontend (Kullanıcı Sitesi)

#### Ana Sayfa
![Ana Sayfa](screenshots/Ekran%20görüntüsü%202026-05-17%20152626.png)

#### Hakkımızda Bölümü
![Hakkımızda](screenshots/Ekran%20görüntüsü%202026-05-17%20152733.png)

#### Hizmetler
![Hizmetler](screenshots/Ekran%20görüntüsü%202026-05-17%20152743.png)

#### Programlar
![Programlar](screenshots/Ekran%20görüntüsü%202026-05-17%20152817.png)

#### Etkinlikler
![Etkinlikler](screenshots/Ekran%20görüntüsü%202026-05-17%20152833.png)

#### Eğitmenler
![Eğitmenler](screenshots/Ekran%20görüntüsü%202026-05-17%20152853.png)

#### Yorumlar
![Yorumlar](screenshots/Ekran%20görüntüsü%202026-05-17%20152907.png)

#### Footer
![Footer](screenshots/Ekran%20görüntüsü%202026-05-17%20153032.png)

---

### 🔧 Admin Panel

#### Admin Dashboard
![Admin Dashboard](screenshots/Ekran%20görüntüsü%202026-05-17%20153057.png)

#### Admin Menü
![Admin Menü](screenshots/Ekran%20görüntüsü%202026-05-17%20153119.png)

#### Liste Görünümü
![Liste](screenshots/Ekran%20görüntüsü%202026-05-17%20153134.png)



## 📁 Proje Yapısı

BabyCareProject/
│
├── 📂 Areas/
│   └── Admin/
│       ├── Controllers/          # Admin Controller'lar
│       │   ├── AboutController.cs
│       │   ├── AdminHomeController.cs
│       │   ├── BannerController.cs
│       │   ├── EventController.cs
│       │   ├── FooterGalleryController.cs
│       │   ├── FooterInformationController.cs
│       │   ├── InstructorController.cs
│       │   ├── ProductController.cs
│       │   ├── ServiceController.cs
│       │   ├── TestimonialController.cs
│       │   └── UILayoutController.cs
│       │
│       └── Views/                 # Admin View'lar
│           ├── About/
│           ├── AdminHome/
│           ├── Banner/
│           ├── Event/
│           ├── FooterGallery/
│           ├── FooterInformation/
│           ├── Instructor/
│           ├── Product/
│           ├── Service/
│           ├── Testimonial/
│           ├── UILayout/          # Frontend görünüm
│           └── Shared/
│               └── _AdminLayout.cshtml
│
├── 📂 Controllers/                # Ana controller'lar
│
├── 📂 DataAccess/
│   ├── Entities/                  # MongoDB Entity'ler
│   │   ├── About.cs
│   │   ├── Banner.cs
│   │   ├── Event.cs
│   │   ├── FooterGallery.cs
│   │   ├── FooterInformation.cs
│   │   ├── FooterSubscribe.cs
│   │   ├── Instructor.cs
│   │   ├── Product.cs
│   │   ├── Service.cs
│   │   └── Testimonial.cs
│   │
│   └── Settings/                  # Veritabanı ayarları
│       ├── DatabaseSettings.cs
│       └── IDatabaseSettings.cs
│
├── 📂 Dtos/                       # Data Transfer Objects
│   ├── AboutDtos/
│   ├── BannerDtos/
│   ├── EventDtos/
│   ├── FooterDtos/
│   ├── InstructorDtos/
│   ├── ProductDtos/
│   ├── ServiceDtos/
│   └── TestimonialDtos/
│
├── 📂 Mappings/                   # AutoMapper Profilleri
│   ├── AboutMapping.cs
│   ├── BannerMapping.cs
│   ├── EventMapping.cs
│   ├── InstructorMapping.cs
│   ├── ProductMapping.cs
│   ├── ServiceMapping.cs
│   └── TestimonialMapping.cs
│
├── 📂 Models/                     # View Models
│
├── 📂 Services/                   # Business Logic
│   ├── AboutServices/
│   ├── BannerServices/
│   ├── EventServices/
│   ├── FooterServices/
│   ├── InstructorServices/
│   ├── ProductServices/
│   ├── ServiceServices/
│   └── TestimonialServices/
│
├── 📂 ViewComponents/             # View Components
│   └── UILayout/
│       ├── AboutViewComponent.cs
│       ├── BannerViewComponent.cs
│       ├── EventViewComponent.cs
│       ├── FooterGalleryViewComponent.cs
│       ├── FooterInformationViewComponent.cs
│       ├── FooterSubscribeViewComponent.cs
│       ├── InstructorViewComponent.cs
│       ├── NavbarViewComponent.cs
│       ├── ProductViewComponent.cs
│       ├── ServiceViewComponent.cs
│       └── TestimonialViewComponent.cs
│
├── 📂 Views/                      # Ana Views
│   ├── Shared/
│   └── _ViewImports.cshtml
│
├── 📂 wwwroot/                    # Static Dosyalar
│   ├── BabyCare-1.0.0/           # Frontend Template
│   │   ├── css/
│   │   ├── js/
│   │   ├── img/
│   │   └── lib/
│   │
│   └── Breeze-Free-Bootstrap-Admin-Template-1.0.0/
│       └── assets/                # Admin Template
│
├── 📂 screenshots/                # README Görselleri
│
├── 📄 appsettings.json           # Ayarlar
├── 📄 Program.cs                 # Ana Program
├── 📄 ScaffoldingReadMe.txt
└── 📄 README.md                  # Bu dosya

---

## 🗄️ Veritabanı Yapılandırması

### appsettings.json

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "DatabaseSettings": {
    "ConnectionString": "mongodb://localhost:27017",
    "DatabaseName": "BabyCareDb",
    "InstructorCollectionName": "Instructors",
    "ProductCollectionName": "Products",
    "BannerCollectionName": "Banners",
    "AboutCollectionName": "Abouts",
    "ServiceCollectionName": "Services",
    "EventCollectionName": "Events",
    "TestimonialCollectionName": "Testimonials",
    "FooterInformationCollectionName": "FooterInformations",
    "FooterGalleryCollectionName": "FooterGalleries",
    "FooterSubscribeCollectionName": "FooterSubscribes"
  }
}
```

### MongoDB Koleksiyonları

| Koleksiyon | Açıklama |
|------------|----------|
| `Banners` | Öne çıkan alan/slider verileri |
| `Abouts` | Hakkımızda bilgileri |
| `Services` | Hizmet verileri |
| `Products` | Program/Kurs verileri |
| `Events` | Etkinlik verileri |
| `Instructors` | Eğitmen profilleri |
| `Testimonials` | Müşteri yorumları |
| `FooterGalleries` | Footer galeri resimleri |
| `FooterInformations` | İletişim bilgileri |
| `FooterSubscribes` | E-bülten abonelikleri |

### Örnek Veri Ekleme

MongoDB Compass'ı açın ve `BabyCareDb` veritabanını oluşturun:

**Banner Örneği:**
```json
{
  "Title": "Hoş Geldiniz",
  "Subtitle": "BabyCare Eğitim ve Gelişim Merkezi",
  "ImageUrl": "~/BabyCare-1.0.0/img/carousel-1.jpg",
  "ButtonText": "Keşfet",
  "ButtonUrl": "#about",
  "Order": 1,
  "IsActive": true
}
```

**Product Örneği:**
```json
{
  "Title": "Günlük İngilizce",
  "Description": "Çocuklarınız için özel hazırlanmış İngilizce eğitim programı.",
  "Price": 500,
  "ImageUrl": "~/BabyCare-1.0.0/img/program-1.jpg",
  "InstructorName": "Ayşe Yılmaz"
}
```

---

## 🚀 Kullanım

### Admin Panel URL'leri

| Modül | URL | Açıklama |
|-------|-----|----------|
| **Dashboard** | `/Admin/AdminHome/Index` | Ana sayfa |
| **Banner** | `/Admin/Banner/Index` | Slider yönetimi |
| **Hakkımızda** | `/Admin/About/Index` | Şirket bilgileri |
| **Hizmetler** | `/Admin/Service/Index` | Hizmet yönetimi |
| **Programlar** | `/Admin/Product/Index` | Kurs yönetimi |
| **Etkinlikler** | `/Admin/Event/Index` | Etkinlik yönetimi |
| **Eğitmenler** | `/Admin/Instructor/Index` | Öğretmen yönetimi |
| **Yorumlar** | `/Admin/Testimonial/Index` | Testimonial yönetimi |
| **Galeri** | `/Admin/FooterGallery/Index` | Footer galeri |
| **İletişim** | `/Admin/FooterInformation/Index` | İletişim bilgileri |
| **Site Önizleme** | `/Admin/UILayout/Index` | Frontend görünüm |

---

## 💡 Mimari Yaklaşım

### ViewComponent Pattern

Proje, ViewComponent mimarisini kullanarak modüler ve tekrar kullanılabilir kod yapısı sunar:

```csharp
[ViewComponent(Name = "BannerViewComponent")]
public class BannerViewComponent : ViewComponent
{
    private readonly IBannerService _bannerService;

    public BannerViewComponent(IBannerService bannerService)
    {
        _bannerService = bannerService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await _bannerService.GetAllBannerAsync();
        return View(values);
    }
}
```

### Service Layer Pattern

```csharp
public interface IBannerService
{
    Task<List<ResultBannerDto>> GetAllBannerAsync();
    Task<ResultBannerDto> GetBannerByIdAsync(string id);
    Task CreateBannerAsync(CreateBannerDto createBannerDto);
    Task UpdateBannerAsync(UpdateBannerDto updateBannerDto);
    Task DeleteBannerAsync(string id);
}
```
