using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceEFandUsingRealtionship.Models
{
    public class Author
    {
        [Required]
        [Key]
        public int Id { get; set; }

        /*
         * No ID primary Key is used.
         * Instead we wil use the FirstName and LastName as the unique Combination
         * This will be set using Fluent API in the AppDbContext
         * 
         * [Key] attribute can be use for primary keys that don't follow 
         * conventions example:
         * 
         * [Key]
         * public string BookIndetifier {get; set;}
         */
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [NotMapped] //Means doesn't need to be stored in the database
        public string FullName
        {
            get
            {
                return $"{FirstName} {MiddleName} {LastName}";
            }
        }

        public string LastName { get; set; }

        public DateTime DoB { get; set; }

        public string Nationality { get; set; }

        public List<Book> Books { get; set; }


    }
}
