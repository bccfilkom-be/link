using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Links")]
    public class Link
    {
        [Column(TypeName = "bigint")]
        public long Id { get; set; }
        [Column(TypeName = "uuid")]
        public Guid TreeId { get; set; }
        public string Uri { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string? ImageUri { get; set; }
        public Tree? Tree { get; set; }
    }
}