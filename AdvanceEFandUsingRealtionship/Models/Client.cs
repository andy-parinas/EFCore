﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceEFandUsingRealtionship.Models
{
    public class Client
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(64)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(64)]
        public string Email { get; set; }

        [Required]
        [MaxLength(64)]
        public string Phone { get; set; }

        public Membership Membership { get; set; }

        public PersonalLibrary PersonalLibrary { get; set; }

    }
}
