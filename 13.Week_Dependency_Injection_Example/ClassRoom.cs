namespace _13.Week_Dependency_Injection_Example
{
    public class ClassRoom
    {
        public IOgretmen Teacher { get; } // Öğretmeni temsil eden özellik

        // Constructor: Öğretmen nesnesini alır
        public ClassRoom(IOgretmen teacher)
        {
            Teacher = teacher; // Öğretmen atanır
        }

        public string GetTeacherInfo()
        {
            return Teacher.GetInfo(); // Öğretmen bilgilerini döndüren metot
        }
    }
}

