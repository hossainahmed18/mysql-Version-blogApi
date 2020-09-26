using blogApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace blogApi.Context
{
   public class MainContext: DbContext{
        public MainContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User>users{set;get;}
        public DbSet<Post>posts{set;get;}
        public DbSet<Comment>comments{set;get;}

    }
}