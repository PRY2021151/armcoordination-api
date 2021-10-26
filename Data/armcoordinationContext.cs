using armcoordination_api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace armcoordination_api.Data
{
    public class armcoordinationContext : DbContext
    {
        public armcoordinationContext(DbContextOptions<armcoordinationContext> options) : base(options) { }

        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<session> session { get; set; }
        public DbSet<child> child { get; set; }
    }
}
