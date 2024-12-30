# Dependency Injection Example

## İçindekiler
- [Giriş](#giriş)
- [Teknolojiler](#teknolojiler)
- [Kod](#kod)
- [Kullanım](#kullanım)
- [Açıklama](#açıklama)
- [Çıktı](#çıktı)
- [Lisans](#lisans)

## Giriş
Bu proje, C# dilinde Dependency Injection (Bağımlılık Enjeksiyonu) kavramını basit bir örnek üzerinden açıklamaktadır. Projede, bir sınıfın başka bir sınıfa bağımlılığını azaltmak ve daha esnek bir yapı oluşturmak için Dependency Injection kullanılmıştır.

## Teknolojiler
- C#
- .NET Framework veya .NET Core

## Kod
### IOgretmen Arayüzü
```csharp
public interface IOgretmen
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string GetInfo();
}
```

### Ogretmen Sınıfı
```csharp
public class Ogretmen : IOgretmen
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Ogretmen(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetInfo()
    {
        return $"Öğretmen: {FirstName} {LastName}";
    }
}
```

### ClassRoom Sınıfı
```csharp
public class ClassRoom
{
    public IOgretmen Teacher { get; }

    public ClassRoom(IOgretmen teacher)
    {
        Teacher = teacher;
    }

    public string GetTeacherInfo()
    {
        return Teacher.GetInfo();
    }
}
```

### Program Sınıfı
```csharp
class Program
{
    static void Main(string[] args)
    {
        IOgretmen teacher = new Ogretmen("Gözde", "Süner");
        ClassRoom classRoom = new ClassRoom(teacher);
        Console.WriteLine(classRoom.GetTeacherInfo());
    }
}
```

## Kullanım
1. Proje dosyasını bir C# IDE'sine (örneğin Visual Studio) yükleyin.
2. Kodun derlenebilir olduğundan emin olun.
3. `Program` sınıfını çalıştırın.

## Açıklama
- **IOgretmen Arayüzü**: Öğretmen sınıfının özelliklerini ve metodunu tanımlar.
- **Ogretmen Sınıfı**: `IOgretmen` arayüzünü uygular ve öğretmenin bilgilerini tutar.
- **ClassRoom Sınıfı**: Dependency Injection kullanılarak bir öğretmen nesnesi alır ve bu nesne üzerinden işlem yapar.
- **Program Sınıfı**: Öğretmen ve ClassRoom nesnelerini oluşturur ve ekrana öğretmen bilgilerini yazdırır.

## Çıktı
```plaintext
Öğretmen: Gözde Süner
```

## Lisans
Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için [LICENSE](LICENSE) dosyasını inceleyin.
