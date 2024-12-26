namespace _13.Week_Dependency_Injection_Example
{
    public class Ogretmen : IOgretmen
    {
        public string FirstName { get; set; } // Öğretmenin adı
        public string LastName { get; set; }  // Öğretmenin soyadı

        // Constructor: Öğretmenin adını ve soyadını alır
        public Ogretmen(string firstName, string lastName)
        {
            FirstName = firstName; // Ad atanır
            LastName = lastName;   // Soyad atanır
        }

        public string GetInfo()
        {
            return $"Öğretmen: {FirstName} {LastName}"; // Bilgiler döndürülür
        }
    }
}
