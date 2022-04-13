using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAppMigracion0._1.Models.BD
{
    public partial class dbMigracionContext : DbContext
    {
        public dbMigracionContext()
        {
        }

        public dbMigracionContext(DbContextOptions<dbMigracionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ListTablaEstado> Estados { get; set; }
        public virtual DbSet<Modeloequipo> Modeloequipos { get; set; }
        public virtual DbSet<ListTablaPersona> Personas { get; set; }
        public virtual DbSet<ListTablaSolicitud> Solicituds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-3IAQ8PH;Database=dbMigracion;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<ListTablaEstado>(entity =>
            {
                entity.HasKey(e => e.Estado1)
                    .HasName("PK__estados__40237F17ACBD26B4");

                entity.ToTable("estados");

                entity.Property(e => e.Estado1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado");
            });

            modelBuilder.Entity<Modeloequipo>(entity =>
            {
                entity.ToTable("modeloequipo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estadoId");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.PersonaId).HasColumnName("personaId");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Modeloequipos)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estados");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Modeloequipos)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_persona");
            });

            modelBuilder.Entity<ListTablaPersona>(entity =>
            {
                entity.ToTable("persona");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Pasaporte).HasColumnName("pasaporte");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sexo");
            });

            modelBuilder.Entity<ListTablaSolicitud>(entity =>
            {
                entity.ToTable("solicitud");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.NombreEstado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_estado");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
