using curdtask.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curdtask.Data
{
    internal class ApplictionDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=curdtaskasp9n;Trusted_Connection=True;TrustServerCertificate=true");
        }
       
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
