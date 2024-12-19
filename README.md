# **12.Week_Code_First_1**

## **İçindekiler**

1. [Giriş](#giriş)  
2. [Kullanılan Teknolojiler](#kullanılan-teknolojiler)  
3. [Kod Açıklaması](#kod-açıklaması)  
4. [Veri Modeli ve Yapılandırma](#veri-modeli-ve-yapılandırma)  
5. [Kullanım](#kullanım)  
6. [Çıktı](#çıktı)  
7. [Lisans](#lisans)  

---

## **Giriş**

Bu proje, Entity Framework Core kullanılarak "Code-First" yaklaşımıyla bir `DbContext` sınıfı üzerinden **Filmler (Movies)** ve **Oyunlar (Games)** için bir veritabanı oluşturmayı amaçlamaktadır. İlgili sınıflar ve yapılandırmalar sayesinde PostgreSQL veritabanı ile iletişim sağlanır.

---

## **Kullanılan Teknolojiler**

- **C#**  
- **Entity Framework Core**  
- **PostgreSQL**  
- **.NET 6/7**  

---

## **Kod Açıklaması**

Bu projede iki temel sınıf (`Movie` ve `Game`) tanımlanmış ve veritabanı için yapılandırılmıştır.  
- **Game**: Oyunların adı, platformu ve derecelendirmesi gibi özellikleri içerir.  
- **Movie**: Filmlerin başlıkları, türleri ve çıkış yılları gibi bilgileri barındırır.  

`PatikaFirstDbContext` sınıfı, PostgreSQL'e bağlantı sağlar ve verilerin `DbSet` olarak yönetilmesine olanak tanır.

---

## **Veri Modeli ve Yapılandırma**

- `Game` için özellikler:  
  - **Id**: Benzersiz bir anahtar (primary key).  
  - **Name**: Oyunun adı (zorunlu, maksimum 100 karakter).  
  - **Platform**: Oyunun oynandığı platform (zorunlu, maksimum 100 karakter).  
  - **Rating**: Oyunun derecelendirmesi (decimal formatı).  

- `Movie` için özellikler:  
  - **Id**: Benzersiz bir anahtar (primary key).  
  - **Title**: Filmin adı (zorunlu, maksimum 100 karakter).  
  - **Genre**: Filmin türü.  
  - **ReleaseYear**: Filmin çıkış yılı (zorunlu).  

### **Veri Tohumu (Seed Data)**

`OnModelCreating` metodu ile başlangıç verileri tanımlanmıştır:  
**Oyunlar (Games)**:  
1. Elden Ring  
2. God of War: Ragnarok  
3. Forza Horizon 5  
4. The Legend of Zelda: Breath of the Wild  
5. Hogwarts Legacy  

**Filmler (Movies)**:  
1. Interstellar  
2. Parasite  
3. Mad Max: Fury Road  
4. The Shawshank Redemption  
5. Spirited Away  

---

## **Kullanım**

1. Projeyi çalıştırmadan önce PostgreSQL bağlantı ayarlarını kontrol edin. `Host`, `Username`, `Password` ve `Database` değerlerini kendi sisteminize uygun şekilde güncelleyin.  

2. Aşağıdaki komutları kullanarak veritabanını oluşturun ve migrasyon işlemini tamamlayın:  
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
