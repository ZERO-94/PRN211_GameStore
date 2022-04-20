using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class User
    {
        public User()
        {
            GameLicenses = new HashSet<GameLicense>();
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool Status { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<GameLicense> GameLicenses { get; set; }
    }
}
