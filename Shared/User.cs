namespace hopkins.tech.Shared
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[64];
        public byte[] PasswordSalt { get; set; } = new byte[64];
        public string Role { get; set; } = string.Empty;
    }
}