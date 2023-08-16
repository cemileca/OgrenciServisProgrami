﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OgrenciServis.Persistence.Contexts;

#nullable disable

namespace OgrenciServis.Persistence.Migrations
{
    [DbContext(typeof(OgrenciServisDbContext))]
    [Migration("20230816072040_mig_2")]
    partial class mig_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AdressChild", b =>
                {
                    b.Property<int>("AdressesId")
                        .HasColumnType("integer");

                    b.Property<int>("ChildsId")
                        .HasColumnType("integer");

                    b.HasKey("AdressesId", "ChildsId");

                    b.HasIndex("ChildsId");

                    b.ToTable("AdressChild");
                });

            modelBuilder.Entity("ChildParent", b =>
                {
                    b.Property<int>("ChildsId")
                        .HasColumnType("integer");

                    b.Property<int>("ParentsId")
                        .HasColumnType("integer");

                    b.HasKey("ChildsId", "ParentsId");

                    b.HasIndex("ParentsId");

                    b.ToTable("ChildParent");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AdresDescription")
                        .HasColumnType("text");

                    b.Property<string>("AdressName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<int?>("CountryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("integer");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("ParentId");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BeginingDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IndivudialNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ParentId")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("text");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text");

                    b.Property<decimal?>("ServiceCost")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Childs");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CityDescription")
                        .HasColumnType("text");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("CountryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UlkeCountryCode")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DistrictDescription")
                        .HasColumnType("text");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("District");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.Kinship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("KinshipDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KinshipName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Kinship");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ChildId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IndivudialNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("KinshipId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("text");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("AdressChild", b =>
                {
                    b.HasOne("OgrenciServis.Domain.Entities.Adress", null)
                        .WithMany()
                        .HasForeignKey("AdressesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OgrenciServis.Domain.Entities.Child", null)
                        .WithMany()
                        .HasForeignKey("ChildsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChildParent", b =>
                {
                    b.HasOne("OgrenciServis.Domain.Entities.Child", null)
                        .WithMany()
                        .HasForeignKey("ChildsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OgrenciServis.Domain.Entities.Parent", null)
                        .WithMany()
                        .HasForeignKey("ParentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.Adress", b =>
                {
                    b.HasOne("OgrenciServis.Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("OgrenciServis.Domain.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("OgrenciServis.Domain.Entities.District", "District")
                        .WithMany("Adresses")
                        .HasForeignKey("DistrictId");

                    b.HasOne("OgrenciServis.Domain.Entities.Parent", null)
                        .WithMany("Adresses")
                        .HasForeignKey("ParentId");

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("District");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.City", b =>
                {
                    b.HasOne("OgrenciServis.Domain.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.District", b =>
                {
                    b.HasOne("OgrenciServis.Domain.Entities.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.Kinship", b =>
                {
                    b.HasOne("OgrenciServis.Domain.Entities.Parent", null)
                        .WithMany("Kinships")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.City", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.District", b =>
                {
                    b.Navigation("Adresses");
                });

            modelBuilder.Entity("OgrenciServis.Domain.Entities.Parent", b =>
                {
                    b.Navigation("Adresses");

                    b.Navigation("Kinships");
                });
#pragma warning restore 612, 618
        }
    }
}
