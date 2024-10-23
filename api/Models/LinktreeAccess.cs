using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("LinktreeAccess")]
    public class LinktreeAccess
    {
        [Column(TypeName = "uuid")]
        public Guid TreeId { get; set; }
        [Column(TypeName = "uuid")]
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Tree? Tree { get; set; }
    }
}