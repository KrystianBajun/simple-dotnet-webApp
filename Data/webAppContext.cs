using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webApp.Models;

namespace webApp.Data
{
    public class webAppContext : DbContext
    {
        public webAppContext (DbContextOptions<webAppContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
