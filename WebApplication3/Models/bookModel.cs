namespace WebApplication3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class bookModel : DbContext
    {
        public bookModel()
            : base("name=bookDBContext")
        {
        }

        public virtual DbSet<SysUser> SysUsers { get; set; }
        public virtual DbSet<SysRole> SysRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysUser>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<SysUser>()
                .Property(e => e.RoleNum)
                .IsFixedLength();

            modelBuilder.Entity<SysRole>()
                .Property(e => e.RoleName)
                .IsFixedLength();

            modelBuilder.Entity<SysRole>()
                .Property(e => e.RoleNum)
                .IsFixedLength();
        }
    }
}
