namespace _12.Week_Code_First_Relation.PatikaCodeFirstDb2
{
    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public int UserId { get; set; }

        public Users Users { get; set; }

    }
}
