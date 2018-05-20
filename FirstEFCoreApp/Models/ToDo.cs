using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEFCoreApp.Models
{
    public class ToDo : BaseEntity
    {
        //public int Id { get; set; } //can be inherited from the BaseEntityClass

        [Required]
        public string Text { get; set; }

        [Required]
        public bool Completed { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime CompletedAt { get; set; }

    }
}
