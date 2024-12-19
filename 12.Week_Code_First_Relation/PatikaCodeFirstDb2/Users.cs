namespace _12.Week_Code_First_Relation.PatikaCodeFirstDb2
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string Email { get; set; } = "";

        //Kullanıcının birden çok post u olabilir.
        public ICollection<Posts> Posts { get; set; }

    }
}
