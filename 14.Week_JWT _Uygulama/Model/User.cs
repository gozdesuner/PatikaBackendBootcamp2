namespace _14.Week_JWT__Uygulama.Model
{
    public class User
    {
        public int Id { get; set; } // Kullanıcı kimliği
        public string? Email { get; set; } // Kullanıcının e-posta adresi
        public string? Password { get; set; } // Kullanıcının şifresi (şifrelenmiş olacak)
    }
}
