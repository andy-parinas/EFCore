using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEFCoreApp.Models
{
    public class Contact : BaseEntity
    {

        //public int Id { get; set; } //Can be Inherited from the BaseEntity Class

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }


    }
}
