using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceEFandUsingRealtionship.Models
{
    public enum Type
    {
        Regular,
        Silver,
        Gold
    }

    public class Membership
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime Initiated { get; set; }

        public Type Type { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }


    }
}
