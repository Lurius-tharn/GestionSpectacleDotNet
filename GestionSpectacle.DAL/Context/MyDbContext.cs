using GestionSpectacle.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionSpectacle.DAL.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;
    public virtual DbSet<BilletHistorique> BilletHistoriques { get; set; } = null!;

    public virtual DbSet<Billet> Billets { get; set; } = null!;
    public virtual DbSet<Spectacle> Spectacles { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseMySql(
                "server=localhost;port=3306;database=GestionSpectacle;uid=GestionSpectacle;password=GestionSpectacle"
                ,
                ServerVersion.Parse("8.0.30-mysql"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Billet>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("billet");

            entity.HasIndex(e => e.IdSpectacle, "Billet_spectacle_null_fk");

            entity.HasIndex(e => e.IdUtilisateur, "Billet_utilisateur_null_fk");

            entity.Property(e => e.IdSpectacle).HasColumnName("idSpectacle");

            entity.Property(e => e.IdUtilisateur).HasColumnName("idUtilisateur");

            entity.Property(e => e.Statut)
                .HasMaxLength(36)
                .HasColumnName("statut");
            entity.Property(e => e.numeroBillet)
                .HasColumnName("numeroBillet");


            entity.HasOne(d => d.IdSpectacleNavigation)
                .WithMany()
                .HasForeignKey(d => d.IdSpectacle)
                .HasConstraintName("Billet_spectacle_null_fk");

            entity.HasOne(d => d.IdUtilisateurNavigation)
                .WithMany()
                .HasForeignKey(d => d.IdUtilisateur)
                .HasConstraintName("Billet_utilisateur_null_fk");
        });

        modelBuilder.Entity<Spectacle>(entity =>
        {
            entity.ToTable("spectacle");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Date)
                .HasMaxLength(36)
                .HasColumnName("date");

            entity.Property(e => e.Lieu)
                .HasMaxLength(36)
                .HasColumnName("lieu");

            entity.Property(e => e.NbPlace)
                .HasMaxLength(36)
                .HasColumnName("nbPlace");

            entity.Property(e => e.Titre)
                .HasMaxLength(36)
                .HasColumnName("titre");

            entity.Property(e => e.imageUrl)
                .HasColumnName("imageUrl");

            entity.Property(e => e.IdApi)
                .HasColumnName("IdApi");

            entity.Property(e => e.Type)
                .HasColumnName("Type");
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.ToTable("utilisateur");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Nom)
                .HasMaxLength(36)
                .HasColumnName("nom");
            entity.Property(e => e.UserName)
                .HasMaxLength(36)
                .HasColumnName("userName");
            entity.Property(e => e.Password)
                .HasMaxLength(36)
                .HasColumnName("password");
            entity.Property(e => e.Salt)
                .HasColumnName("salt");
        });
        modelBuilder.Entity<BilletHistorique>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("billetHistorique");

            entity.HasIndex(e => e.IdSpectacle, "Billet_spectacle_null_fk");

            entity.HasIndex(e => e.IdUtilisateur, "Billet_utilisateur_null_fk");

            entity.Property(e => e.IdSpectacle).HasColumnName("idSpectacle");

            entity.Property(e => e.IdUtilisateur).HasColumnName("idUtilisateur");

            entity.Property(e => e.Statut)
                .HasMaxLength(36)
                .HasColumnName("statut");
            entity.Property(e => e.numeroBillet)
                .HasColumnName("numeroBillet");

            entity.Property(e => e.DateSuppression)
                .HasColumnName("dateSuppression");
            entity.HasOne(d => d.IdSpectacleNavigation)
                .WithMany()
                .HasForeignKey(d => d.IdSpectacle)
                .HasConstraintName("Billet_spectacle_null_fk");

            entity.HasOne(d => d.IdUtilisateurNavigation)
                .WithMany()
                .HasForeignKey(d => d.IdUtilisateur)
                .HasConstraintName("Billet_utilisateur_null_fk");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}