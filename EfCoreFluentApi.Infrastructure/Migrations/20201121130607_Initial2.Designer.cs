﻿// <auto-generated />
using System;
using EfCoreFluentApi.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EfCoreFluentApi.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201121130607_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EfCoreFluentApi.Domain.Entities.App", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Apps");
                });

            modelBuilder.Entity("EfCoreFluentApi.Domain.Entities.AppSettings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("AppSettings");
                });

            modelBuilder.Entity("EfCoreFluentApi.Domain.Entities.App", b =>
                {
                    b.HasOne("EfCoreFluentApi.Domain.Entities.AppSettings", "Settings")
                        .WithOne("App")
                        .HasForeignKey("EfCoreFluentApi.Domain.Entities.App", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("EfCoreFluentApi.Domain.Entities.AppSettings", b =>
                {
                    b.OwnsMany("EfCoreFluentApi.Domain.ValueObjects.Setting", "Settings", b1 =>
                        {
                            b1.Property<Guid>("AppSettingsId")
                                .HasColumnType("uuid");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .UseIdentityByDefaultColumn();

                            b1.Property<string>("Key")
                                .HasMaxLength(150)
                                .HasColumnType("character varying(150)")
                                .HasColumnName("Setting_Key");

                            b1.Property<string>("Type")
                                .HasMaxLength(150)
                                .HasColumnType("character varying(150)")
                                .HasColumnName("Setting_Type");

                            b1.Property<string>("Value")
                                .HasMaxLength(350)
                                .HasColumnType("character varying(350)")
                                .HasColumnName("Setting_Value");

                            b1.HasKey("AppSettingsId", "Id");

                            b1.ToTable("Setting");

                            b1.WithOwner()
                                .HasForeignKey("AppSettingsId");
                        });

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("EfCoreFluentApi.Domain.Entities.AppSettings", b =>
                {
                    b.Navigation("App");
                });
#pragma warning restore 612, 618
        }
    }
}
