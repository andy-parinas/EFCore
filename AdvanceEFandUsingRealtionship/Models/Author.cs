﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceEFandUsingRealtionship.Models
{
    public class Author
    {
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

        public string LastName { get; set; }

        public DateTime DoB { get; set; }

        public string Nationality { get; set; }


    }
}