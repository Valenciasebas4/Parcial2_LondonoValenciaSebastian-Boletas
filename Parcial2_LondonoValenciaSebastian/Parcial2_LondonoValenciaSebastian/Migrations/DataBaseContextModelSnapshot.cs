﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial2_LondonoValenciaSebastian.DAL;

#nullable disable

namespace Parcial2_LondonoValenciaSebastian.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Parcial2_LondonoValenciaSebastian.DAL.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntranceGate")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool?>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("42eb9221-d1ae-45f9-b1b6-7c19c5c0220a"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("dd16bed7-d68f-4636-b21a-2464aaeb2700"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("02553a4b-41fd-4c7f-ad45-c76d521c70f1"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("4b042054-a1ab-4378-ab27-fe7692f7e80e"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("043fb24c-0434-4f34-9c2e-fa59a3ff4591"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("0297a28c-c453-450a-b8a7-68a1ffa78ffb"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("bd0a013c-7049-40f5-8f26-c53d4063ae42"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("0b9bef11-5b01-4306-8a05-375d21c3ae35"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("5dec9921-3a91-4c57-b0e6-e8c745590e38"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("06fbfc7d-b985-490c-9a23-3c19f13391d0"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("980e2529-c82b-48f4-a50e-a11540cca3c9"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("3be11a97-5e98-46eb-96e8-6bfabb9a8d90"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("5fe6d71f-c21b-498f-a989-271a824ba1a2"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("a07c45c8-f523-4ff5-baeb-d1b2e36d387a"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("a85716fd-44cc-4d0f-a306-8539d3d277fc"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("479a3a38-fa7b-42bc-ba28-8cadefc05b35"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("33fe6e88-8250-40f0-9eb0-3bfa22e55ade"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("b70c1de8-9b7d-47ac-9ffd-e91f01d0d03b"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("788b2abf-34e6-4fdb-83f9-0428211ae857"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("e2214ab4-80ee-477a-b45f-a13c0c126aa2"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("8f7fdc69-af66-4d2d-8ef1-6d4c984c35c4"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("9657eec4-ed56-4dad-ae3d-ceec2ce7c2f1"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("9f31afd5-550b-4f79-b874-d9ea10fb4964"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("fd55ac2e-74bc-4ebc-8b82-18f59e2c867f"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("b8c8e5ad-f3ab-4ef8-8ebf-6c7cba7cf4b6"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("abd2687f-ba6f-4c54-b32e-f196fc288748"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("a5c43eab-43c8-4fc4-bc76-d150b2e59489"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("03a0500b-f7c4-4f35-b376-9edce4c5f146"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("dcff3ffc-a187-43c3-b399-b826a348f515"),
                            IsUsed = false
                        },
                        new
                        {
                            Id = new Guid("19914aca-f321-4096-b493-cd42d8e4f366"),
                            IsUsed = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
