using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstEFCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;

namespace FirstEFCoreApp.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ToDo> ToDos { get; set; }



    }
}
