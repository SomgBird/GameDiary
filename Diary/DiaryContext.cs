using Diary.Models;
using Microsoft.EntityFrameworkCore;


namespace Diary
{
    public class DiaryContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=game_diary.db");
        }
    }
}