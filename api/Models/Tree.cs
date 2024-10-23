using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public enum Visibility
    {
        Public,
        Private
    }

    [Table("Trees")]
    public class Tree
    {
        [Column(TypeName = "uuid")]
        public Guid Id { get; set; }
        [Column(TypeName = "uuid")]
        public Guid UserId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Slug { get; set; }
        public Visibility Visibility { get; set; } = Visibility.Public;
        public string? TreeImageUri { get; set; }
        public User? User { get; set; }
    }
}