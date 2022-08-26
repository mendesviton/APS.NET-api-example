using Data.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ContextWebApi
{

    public class WebApiContext : DbContext
    {
        #region Props
        public DbSet<AnimalModel> animal { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;" +
                "Port=5436;" +
                "Database=postgres;" +
                "User=postgres;" +
                "Password=123456");
        }

    }
}
