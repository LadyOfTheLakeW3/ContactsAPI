using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsAPI.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CategoryName { get; set; }
        public int? SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }


        public ICollection<Contact> Categories { get; set; }
    }
}
