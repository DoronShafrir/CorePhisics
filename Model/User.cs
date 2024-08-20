namespace CorePhisics.Model
{
    public class User
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public int? Phone { get; set; }
        public DateOnly? Birthday { get; set; }
        public bool? Admin { get; set; }
    }
}
