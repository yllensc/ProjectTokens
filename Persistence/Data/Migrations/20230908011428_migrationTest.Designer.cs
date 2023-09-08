﻿// <auto-generated />
using Domine.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(ProjectTokensDbContext))]
    [Migration("20230908011428_migrationTest")]
    partial class migrationTest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domine.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RolName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("RolName")
                        .IsUnique();

                    b.ToTable("Rol", (string)null);
                });

            modelBuilder.Entity("Domine.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Domine.Entities.UserRol", b =>
                {
                    b.Property<int>("IdUserFK")
                        .HasColumnType("int");

                    b.Property<int>("IdRolFK")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IdUserFK", "IdRolFK");

                    b.HasIndex("IdRolFK");

                    b.ToTable("UsersRoles");
                });

            modelBuilder.Entity("Domine.Entities.UserRol", b =>
                {
                    b.HasOne("Domine.Entities.Rol", "Rol")
                        .WithMany("UsersRoles")
                        .HasForeignKey("IdRolFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domine.Entities.User", "User")
                        .WithMany("UsersRoles")
                        .HasForeignKey("IdUserFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domine.Entities.Rol", b =>
                {
                    b.Navigation("UsersRoles");
                });

            modelBuilder.Entity("Domine.Entities.User", b =>
                {
                    b.Navigation("UsersRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
