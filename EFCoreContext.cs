using System;
using EFCoreTuto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EFCoreTuto
{
    public class EFCoreContext: DbContext
    {
        public EFCoreContext() { }
        private readonly EFCoreTutoSetting _secret;
        public EFCoreContext(IOptions<EFCoreTutoSetting> _options) { this._secret = _options.Value; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Attributes> Attributes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=tcp:twglnjsx61.database.windows.net,1433;Initial Catalog=EFCoreTutoDB;Persist Security Info=False;User ID=yar;Password=P@ssw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");             
    }
}
