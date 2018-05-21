using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceEFandUsingRealtionship.Models
{
    public class Book
    {
        public int Id { get; set; }

        [MaxLength(32)]
        public string Title { get; set; }

        public string Author { get; set; }

        public string Isbn { get; set; }
        
        public string FullTitle
        {
            get
            {
                return $"{Author}'s {Title}";
            }
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }


    }
}
