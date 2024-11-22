﻿using API_ProjetoBimestral.Models;
using Microsoft.EntityFrameworkCore;

namespace API_ProjetoBimestral.Services
{
    public class ConnectionContextDB : DbContext
    {
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<PedidoModel> Pedido { get; set; }
        public DbSet<VendedorModel> Vendedor { get; set; }
        public DbSet<LivroModel> Livro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3305;Database=Bibliotecass;Uid=root;Pwd=123;", new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }
}
