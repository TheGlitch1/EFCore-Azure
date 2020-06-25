using System;
using EFCoreTuto.Models;
using Microsoft.EntityFrameworkCore;


namespace EFCoreTuto
{
    public class EFCoreContext: DbContext
    {

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Attributes> Attributes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=tcp:twglnjsx61.database.windows.net,1433;Initial Catalog=EFCoreTutoDB;Persist Security Info=False;User ID=yar;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        
    }
}
