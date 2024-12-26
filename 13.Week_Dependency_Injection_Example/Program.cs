using _13.Week_Dependency_Injection_Example;

class Program
{
    static void Main(string[] args)
    {
        // 1. Öğretmen nesnesi oluşturulur
        IOgretmen teacher = new Ogretmen("Gözde", "Süner");

        // 2. Classroom nesnesi oluşturulur ve öğretmen nesnesi enjekte edilir
        ClassRoom classRoom = new ClassRoom(teacher);

        // 3. Öğretmen bilgileri ekrana yazdırılır
        Console.WriteLine(classRoom.GetTeacherInfo());
    }
}
