using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NetCoreWebApp.Models
{
    public class NetCoreWebAppContext : DbContext
    {
        public NetCoreWebAppContext (DbContextOptions<NetCoreWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<NetCoreWebApp.Models.Movie> Movie { get; set; }
    }
}
