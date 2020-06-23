using System;
using EFCoreTuto.Models;
using Microsoft.EntityFrameworkCore;


namespace EFCoreTuto
{
    public class EFCoreContext: DbContext
    {

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Attributes> Attributes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("");
        
    }
}
