using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NS.DigitalMenuData.Entities
{
    public partial class MenuDBContext : DbContext
    {
        public MenuDBContext()
        {
        }

        public MenuDBContext(DbContextOptions<MenuDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Menu> Menus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-30KT0O04\\SQLEXPRESS;Database=NS.Menu;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.DishId);

                entity.ToTable("Menu");

                entity.Property(e => e.DishId).HasColumnName("DishID");

                entity.Property(e => e.DishCategory).HasMaxLength(50);

                entity.Property(e => e.DishDescription).HasMaxLength(500);

                entity.Property(e => e.DishName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
