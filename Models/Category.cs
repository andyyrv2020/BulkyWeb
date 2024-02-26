using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int CId { get; set; }
        [Required]
        public string Name { get; set; }
        public string DisplayOrder { get; set; }

    }
}
