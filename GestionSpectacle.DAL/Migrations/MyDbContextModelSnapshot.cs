﻿// <auto-generated />
using System;
using EFCoreConsoleApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionSpectacle.DAL.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("GestionSpectacle.DAL.Entities.Billet", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("IdSpectacle")
                        .HasColumnType("int")
                        .HasColumnName("idSpectacle");

                    b.Property<int?>("IdUtilisateur")
                        .HasColumnType("int")
                        .HasColumnName("idUtilisateur");

                    b.Property<string>("Statut")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("statut");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdSpectacle" }, "Billet_spectacle_null_fk");

                    b.HasIndex(new[] { "IdUtilisateur" }, "Billet_utilisateur_null_fk");

                    b.ToTable("billet", (string)null);
                });

            modelBuilder.Entity("GestionSpectacle.DAL.Entities.BilletHistorique", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("DateBillet")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DateBillet");

                    b.Property<int?>("IdBillet")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdBillet");

                    b.ToTable("BilletHistorique", (string)null);
                });

            modelBuilder.Entity("GestionSpectacle.DAL.Entities.Spectacle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Date")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("date");

                    b.Property<string>("Lieu")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("lieu");

                    b.Property<int?>("NbPlace")
                        .HasMaxLength(36)
                        .HasColumnType("int")
                        .HasColumnName("nbPlace");

                    b.Property<string>("Titre")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("titre");

                    b.HasKey("Id");

                    b.ToTable("spectacle", (string)null);
                });

            modelBuilder.Entity("GestionSpectacle.DAL.Entities.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nom")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("nom");

                    b.Property<string>("Password")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("userName");

                    b.HasKey("Id");

                    b.ToTable("utilisateur", (string)null);
                });

            modelBuilder.Entity("GestionSpectacle.DAL.Entities.Billet", b =>
                {
                    b.HasOne("GestionSpectacle.DAL.Entities.Spectacle", "IdSpectacleNavigation")
                        .WithMany()
                        .HasForeignKey("IdSpectacle")
                        .HasConstraintName("Billet_spectacle_null_fk");

                    b.HasOne("GestionSpectacle.DAL.Entities.Utilisateur", "IdUtilisateurNavigation")
                        .WithMany()
                        .HasForeignKey("IdUtilisateur")
                        .HasConstraintName("Billet_utilisateur_null_fk");

                    b.Navigation("IdSpectacleNavigation");

                    b.Navigation("IdUtilisateurNavigation");
                });

            modelBuilder.Entity("GestionSpectacle.DAL.Entities.BilletHistorique", b =>
                {
                    b.HasOne("GestionSpectacle.DAL.Entities.Billet", "IdBilletNavigation")
                        .WithMany()
                        .HasForeignKey("IdBillet")
                        .HasConstraintName("Historique_Billet_billet_null_fk");

                    b.Navigation("IdBilletNavigation");
                });
#pragma warning restore 612, 618
        }
    }
}
