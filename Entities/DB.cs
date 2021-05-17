using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EastViewAPI.Entities
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options)
            : base(options)
        {
        }

        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Task> Tasks { get; set; }

    }
}
