﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonoGamingStore.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MaxService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MaxService.Models.Mantenimiento.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("Password")
                        .HasColumnType("text")
                        .HasColumnName("Password");

                    b.HasKey("Id");

                    b.ToTable("t_login");
                });

            modelBuilder.Entity("MaxService_1.Models.MarcaLlanta", b =>
                {
                    b.Property<int>("MarcaLlantaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("MarcaLlantaId")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("NombreMarca")
                        .HasColumnType("text")
                        .HasColumnName("NombreMarca");

                    b.HasKey("MarcaLlantaId");

                    b.ToTable("T_MarcaLlanta");
                });

            modelBuilder.Entity("MaxService_1.Models.MarcaVehiculo", b =>
                {
                    b.Property<int>("MarcaVehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("MarcaVehiculoId")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Modelo")
                        .HasColumnType("text")
                        .HasColumnName("Modelo");

                    b.Property<string>("NombreMarca")
                        .HasColumnType("text")
                        .HasColumnName("NombreMarca");

                    b.HasKey("MarcaVehiculoId");

                    b.ToTable("T_MarcaVehiculo");
                });

            modelBuilder.Entity("MaxService_1.Models.Producto.DetalleLlanta", b =>
                {
                    b.Property<int>("DetalleLlantaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("DetalleLlantaId")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Clasificacion")
                        .HasColumnType("text")
                        .HasColumnName("Clasificacion");

                    b.Property<string>("CodigoUTQG")
                        .HasColumnType("text")
                        .HasColumnName("CodigoUTQG");

                    b.Property<char>("Construccion")
                        .HasColumnType("character(1)")
                        .HasColumnName("Construccion");

                    b.Property<string>("FechaFabricacion")
                        .HasColumnType("text")
                        .HasColumnName("FechaFabricacion");

                    b.Property<string>("FotoLlanta")
                        .HasColumnType("text")
                        .HasColumnName("FotoLlanta");

                    b.Property<int>("IndiceCarga")
                        .HasColumnType("integer")
                        .HasColumnName("IndiceCarga");

                    b.Property<char>("IndiceVelocidad")
                        .HasColumnType("character(1)")
                        .HasColumnName("IndiceVelocidad");

                    b.Property<string>("LimiteCarga")
                        .HasColumnType("text")
                        .HasColumnName("LimiteCarga");

                    b.Property<int>("MarcaLlantaId")
                        .HasColumnType("integer");

                    b.Property<int>("MedidaLlantaId")
                        .HasColumnType("integer");

                    b.Property<string>("PresionMaxima")
                        .HasColumnType("text")
                        .HasColumnName("PresionMaxima");

                    b.HasKey("DetalleLlantaId");

                    b.HasIndex("MarcaLlantaId");

                    b.HasIndex("MedidaLlantaId");

                    b.ToTable("T_DetalleLlanta");
                });

            modelBuilder.Entity("MaxService_1.Models.Producto.Llanta", b =>
                {
                    b.Property<int>("LlantaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("LlantaId")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DetalleLlantaId")
                        .HasColumnType("integer");

                    b.Property<double>("Precio")
                        .HasColumnType("double precision")
                        .HasColumnName("Precio");

                    b.Property<int>("Stock")
                        .HasColumnType("integer")
                        .HasColumnName("Stock");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("integer");

                    b.HasKey("LlantaId");

                    b.HasIndex("DetalleLlantaId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("T_Llanta");
                });

            modelBuilder.Entity("MaxService_1.Models.Producto.MedidaLlanta", b =>
                {
                    b.Property<int>("MedidaLlantaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("MedidaLlantaId")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Ancho")
                        .HasColumnType("integer")
                        .HasColumnName("Ancho");

                    b.Property<int>("Diametro")
                        .HasColumnType("integer")
                        .HasColumnName("Diametro");

                    b.Property<int>("Perfil")
                        .HasColumnType("integer")
                        .HasColumnName("Perfil");

                    b.HasKey("MedidaLlantaId");

                    b.ToTable("T_MedidaLlanta");
                });

            modelBuilder.Entity("MaxService_1.Models.Producto.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("VehiculoId")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FotoVehiculo")
                        .HasColumnType("text")
                        .HasColumnName("FotoVehiculo");

                    b.Property<int>("MarcaVehiculoId")
                        .HasColumnType("integer");

                    b.Property<string>("TipoVehiculo")
                        .HasColumnType("text")
                        .HasColumnName("TipoVehiculo");

                    b.HasKey("VehiculoId");

                    b.HasIndex("MarcaVehiculoId");

                    b.ToTable("T_Vehiculo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MaxService_1.Models.Producto.DetalleLlanta", b =>
                {
                    b.HasOne("MaxService_1.Models.MarcaLlanta", "MarcaLlanta")
                        .WithMany()
                        .HasForeignKey("MarcaLlantaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MaxService_1.Models.Producto.MedidaLlanta", "MedidaLlanta")
                        .WithMany()
                        .HasForeignKey("MedidaLlantaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MarcaLlanta");

                    b.Navigation("MedidaLlanta");
                });

            modelBuilder.Entity("MaxService_1.Models.Producto.Llanta", b =>
                {
                    b.HasOne("MaxService_1.Models.Producto.DetalleLlanta", "DetalleLlanta")
                        .WithMany()
                        .HasForeignKey("DetalleLlantaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MaxService_1.Models.Producto.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetalleLlanta");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("MaxService_1.Models.Producto.Vehiculo", b =>
                {
                    b.HasOne("MaxService_1.Models.MarcaVehiculo", "MarcaVehiculo")
                        .WithMany()
                        .HasForeignKey("MarcaVehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MarcaVehiculo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
