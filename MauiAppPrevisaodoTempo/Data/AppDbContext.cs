using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrevisaoDoTempoApp.Models;

namespace MauiAppPrevisaodoTempo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<PrevisaoTempo> PrevisaoTempos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "previsao.db")}");
        }
    }
}
