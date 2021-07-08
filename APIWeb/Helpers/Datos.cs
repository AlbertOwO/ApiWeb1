using System;
using APIWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace APIWeb.Helpers
{// comentario
    public class Datos : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; } // tabla categoria la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Conexion = @"Server = sqlserverontiveros.database.windows.net;
                                Database = db1;
                                User = sqluser;
                                Password = Pa$$w0rd1234;";
            optionsBuilder.UseSqlServer(Conexion);
        }
    }
}
