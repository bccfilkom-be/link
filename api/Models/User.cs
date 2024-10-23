using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Users")]
    public class User
    {
        [Column(TypeName = "uuid")]
        public Guid id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? RefreshToken { get; set; }
        public string? Device { get; set; }
        public string? PhotoProfileUri { get; set; }
        public ICollection<Tree> Trees { get; set; } = new List<Tree>();
        public ICollection<LinktreeAccess> LinktreeAccesses { get; set; } = new List<LinktreeAccess>();
    }
}