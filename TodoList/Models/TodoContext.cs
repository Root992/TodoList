using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting.Internal;

namespace TodoList.Models
{
    public class TodoContext: DbContext
    {
        public string DbPath { get; }
        public TodoContext()
        {
            DbPath = "C:\\Users\\nahuel.berardi\\Desktop\\Code\\Todo.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Attivita> attivita { get; set; }
        public DbSet<Utenti> utenti { get; set; }
    }
}
