using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTutorial.EntityDAL
{
    public class EntityContext: DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options):base(options)
        {

        }

        public DbSet<PersonInfo> Persons { get; set; }

        
        public DbSet<Post> Posts { get; set; }
    }
}
