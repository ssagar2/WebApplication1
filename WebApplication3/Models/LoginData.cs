namespace WebApplication3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LoginData : DbContext
    {
        public LoginData()
            : base("name=LoginData")
        {
        }

        public virtual DbSet<LoginTable> LoginTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginTable>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<LoginTable>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<WebApplication3.Models.Image> Images { get; set; }
    }
}
