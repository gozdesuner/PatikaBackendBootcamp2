namespace _13.Week_Dependency_Injection_Example
{
    public interface IOgretmen
    {
        string FirstName { get; set; } // Öğretmenin adı
        string LastName { get; set; }  // Öğretmenin soyadı
        string GetInfo();// Öğretmen bilgilerini döndüren metot
    }
}
