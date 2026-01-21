

namespace eCommerce.Core.Entities
{
    public class ApplicationUser
    {
        public Guid UserID { get; set; }    
        public string? PersonName{ get; set; } = string.Empty;    
       public string? Email { get; set; } = string.Empty;    
        public string? Password { get; set; } = string.Empty;
        public string? Gender { get; set; } = string.Empty;
    }
}
