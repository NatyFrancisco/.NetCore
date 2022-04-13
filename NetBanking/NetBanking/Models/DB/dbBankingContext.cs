using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NetBanking.Models.DB
{
    public partial class dbBankingContext : DbContext
    {
        public dbBankingContext()
        {
        }

        public dbBankingContext(DbContextOptions<dbBankingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cuentum> Cuenta { get; set; }
        public virtual DbSet<Transferencium> Transferencia { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-3IAQ8PH;Database=dbBanking;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cuentum>(entity =>
            {
                entity.HasKey(e => e.NoCuenta)
                    .HasName("PK__cuenta__D7CC179708A818F9");

                entity.ToTable("cuenta");

                entity.Property(e => e.NoCuenta)
                    .ValueGeneratedNever()
                    .HasColumnName("noCuenta");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Transferencium>(entity =>
            {
                entity.ToTable("transferencia");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("banco");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.NoCuenta).HasColumnName("noCuenta");

                entity.Property(e => e.TipoCuenta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoCuenta");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("PK__user__415B7BE4CAEA2DE6");

                entity.ToTable("user");

                entity.Property(e => e.Cedula)
                    .ValueGeneratedNever()
                    .HasColumnName("cedula");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Passw)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passw");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
