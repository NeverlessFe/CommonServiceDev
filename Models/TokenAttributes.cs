namespace CommonServiceCore.Models
{
    public class TokenAttributes
    {
        public string UserAD { get; set; }
        public int IDApps { get; set; }
    }

    public class TokenValue
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public bool IsActive { get; set; }
        public int IdApps { get; set; }
        public DateTime Validation { get; set; }
    }
}
