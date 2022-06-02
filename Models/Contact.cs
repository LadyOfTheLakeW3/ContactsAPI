using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsAPI.Models
{
    public class Contact
    {
        //Brak hasla. Jako, ze nie zdazylam z zakodzeniem logowania skupilam sie na reszcie pol
        [Key]
        public int ContactId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Surname { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string Phone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Birthdate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }



    }
}
