using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsAPI.Models
{
    public class Subcategory
    {
        [Key]
        public int SubcategoryId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string SubcategoryName { get; set; }

        public ICollection<Category> Subcategories { get; set; }
    }
}
