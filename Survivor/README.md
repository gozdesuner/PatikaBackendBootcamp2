
# Survivor Web API Projesi

## İçindekiler
- [Giriş](#giriş)
- [Teknolojiler](#teknolojiler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [API Endpointleri](#api-endpointleri)
- [Veritabanı Yapısı](#veritabanı-yapısı)
- [Lisans](#lisans)

---

## Giriş
Bu proje, **Survivor Yarışmacıları ve Kategorileri** ile ilgili bir **Web API** uygulamasıdır. Proje, yarışmacılar ve kategoriler arasında bir **bire çok (one-to-many)** ilişkisi kurar. Yarışmacılar için CRUD (Create, Read, Update, Delete) işlemleri gerçekleştirilebilir.

---

## Teknolojiler
Bu projede kullanılan başlıca teknolojiler:
- **ASP.NET Core 6.0**
- **Entity Framework Core**
- **PostgreSQL** (Veritabanı)
- **Swagger** (API dokümantasyonu ve testi)
- **Postman** (API testi için)

---

## Kurulum
1. Projeyi klonlayın:
   ```bash
   git clone https://github.com/kullanici-adi/SurvivorWebAPI.git
   cd SurvivorWebAPI
   ```

2. Veritabanını oluşturmak için PostgreSQL kullanın:
   - Veritabanı adı: `SurvivorDb`
   - Kullanıcı adı: `postgres`
   - Şifre: `postgres`

3. Projede gerekli bağımlılıkları yükleyin:
   ```bash
   dotnet restore
   ```

4. Veritabanı migrasyonlarını uygulayın:
   ```bash
   dotnet ef database update
   ```

5. Uygulamayı çalıştırın:
   ```bash
   dotnet run
   ```

6. Tarayıcınızda aşağıdaki adrese gidin:
   ```
   https://localhost:7032/swagger
   ```

---

## Kullanım
Uygulama, yarışmacılar ve kategoriler üzerinde aşağıdaki işlemleri gerçekleştirebilir:
- Yarışmacıları listeleme, ekleme, güncelleme ve silme
- Kategorileri listeleme, ekleme, güncelleme ve silme
- Kategoriye göre yarışmacıları listeleme

---

## API Endpointleri

### **CompetitorController**
- **GET** `/api/competitors` - Tüm yarışmacıları listele
- **GET** `/api/competitors/{id}` - Belirli bir yarışmacıyı getir
- **GET** `/api/competitors/categories/{CategoryId}` - Belirli bir kategoriye ait yarışmacıları getir
- **POST** `/api/competitors` - Yeni bir yarışmacı ekle
- **PUT** `/api/competitors/{id}` - Belirli bir yarışmacıyı güncelle
- **DELETE** `/api/competitors/{id}` - Belirli bir yarışmacıyı sil

### **CategoryController**
- **GET** `/api/categories` - Tüm kategorileri listele
- **GET** `/api/categories/{id}` - Belirli bir kategoriyi getir
- **POST** `/api/categories` - Yeni bir kategori ekle
- **PUT** `/api/categories/{id}` - Belirli bir kategoriyi güncelle
- **DELETE** `/api/categories/{id}` - Belirli bir kategoriyi sil

---

## Veritabanı Yapısı

### **Competitor Tablosu**
| Alan Adı       | Tür              | Açıklama                          |
|----------------|------------------|-----------------------------------|
| Id             | int              | Yarışmacı ID'si (PK)              |
| FirstName      | string           | Yarışmacının adı                  |
| LastName       | string           | Yarışmacının soyadı               |
| CategoryId     | int              | Kategori ID'si (FK)               |
| CreatedDate    | DateTime         | Oluşturulma tarihi                |
| ModifiedDate   | DateTime         | Güncellenme tarihi                |
| IsDeleted      | bool             | Silinip silinmediğini gösterir    |

### **Category Tablosu**
| Alan Adı       | Tür              | Açıklama                          |
|----------------|------------------|-----------------------------------|
| Id             | int              | Kategori ID'si (PK)               |
| Name           | string           | Kategori adı                      |
| CreatedDate    | DateTime         | Oluşturulma tarihi                |
| ModifiedDate   | DateTime         | Güncellenme tarihi                |
| IsDeleted      | bool             | Silinip silinmediğini gösterir    |

---

## Lisans
Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için [LICENSE](LICENSE) dosyasını inceleyin.
