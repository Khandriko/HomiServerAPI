namespace HomiServerAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        // Сделать свойство required
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
    }
}