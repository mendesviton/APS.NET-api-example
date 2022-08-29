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
        public DbSet<AnimalModel> Animal { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }

        public DbSet<PlantaModel> Planta { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;" +
                "Port=5433;" +
                "Database=postgres;" +
                "search path=geral;" +
                "UserId=postgres;" +
                "Password=123456");
        }

    }
}
