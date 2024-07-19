namespace ManagementProduct.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? InactivatedAt { get; private set; }

        public User(string email, string password, string role)
        {
            Email = email;
            Password = password;
            Role = role;
            CreatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);
        }

        public void UpdateUser(string email, string password, string role)
        {
            Email = email;
            Password = password;
            Role = role;
        }

        public void InactivateUser()
        {
            InactivatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);
        }
    }
}
