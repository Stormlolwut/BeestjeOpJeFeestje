﻿// <auto-generated />
using System;
using BeestjeOpJeFeestje.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeestjeOpJeFeestje.Migrations
{
    [DbContext(typeof(BeestjeOpJeFeestjeContext))]
    [Migration("20200111192433_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeestjeOpJeFeestje.Models.Accessories", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PicturePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("AnimalId");

                    b.ToTable("Accessories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Strikje",
                            PicturePath = "/images/accessories/Picture 1.png",
                            Price = 15.0
                        },
                        new
                        {
                            ID = 2,
                            Name = "Strikje Rood",
                            PicturePath = "/images/accessories/Picture 2.png",
                            Price = 15.0
                        },
                        new
                        {
                            ID = 3,
                            Name = "Hoge Hoed",
                            PicturePath = "/images/accessories/Picture 3.png",
                            Price = 30.0
                        },
                        new
                        {
                            ID = 4,
                            Name = "Kerstmuts",
                            PicturePath = "/images/accessories/Picture 4.png",
                            Price = 25.0
                        },
                        new
                        {
                            ID = 5,
                            Name = "Maracas",
                            PicturePath = "/images/accessories/Picture 5.png",
                            Price = 10.0
                        },
                        new
                        {
                            ID = 6,
                            Name = "Hamer",
                            PicturePath = "/images/accessories/Picture 6.png",
                            Price = 3.0
                        },
                        new
                        {
                            ID = 7,
                            Name = "Vleugels",
                            PicturePath = "/images/accessories/Picture 7.png",
                            Price = 40.0
                        },
                        new
                        {
                            ID = 8,
                            Name = "Afro Haar",
                            PicturePath = "/images/accessories/Picture 8.png",
                            Price = 30.0
                        },
                        new
                        {
                            ID = 9,
                            Name = "Wandelstok",
                            PicturePath = "/images/accessories/Picture 9.png",
                            Price = 15.0
                        },
                        new
                        {
                            ID = 10,
                            Name = "Bot",
                            PicturePath = "/images/accessories/Picture 10.png",
                            Price = 1.0
                        },
                        new
                        {
                            ID = 11,
                            Name = "Hengels",
                            PicturePath = "/images/accessories/Picture 11.png",
                            Price = 25.0
                        });
                });

            modelBuilder.Entity("BeestjeOpJeFeestje.Models.Animal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PicturePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Animal");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "aap",
                            PicturePath = "/images/animals/aap.png",
                            Price = 50.0,
                            Type = "Jungle"
                        },
                        new
                        {
                            ID = 2,
                            Name = "bever",
                            PicturePath = "/images/animals/bever.png",
                            Price = 20.0,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 3,
                            Name = "doggo",
                            PicturePath = "/images/animals/doggo.png",
                            Price = 100.0,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 4,
                            Name = "donkey",
                            PicturePath = "/images/animals/donkey.png",
                            Price = 30.0,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 5,
                            Name = "duck",
                            PicturePath = "/images/animals/duck.png",
                            Price = 20.0,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 6,
                            Name = "ijsbeer",
                            PicturePath = "/images/animals/ijsbeer.png",
                            Price = 90.0,
                            Type = "Sneeuw"
                        },
                        new
                        {
                            ID = 7,
                            Name = "kat",
                            PicturePath = "/images/animals/kat.png",
                            Price = 50.0,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 8,
                            Name = "koe",
                            PicturePath = "/images/animals/koe.png",
                            Price = 50.0,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 9,
                            Name = "kuiken",
                            PicturePath = "/images/animals/kuiken.png",
                            Price = 10.0,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 10,
                            Name = "leeuw",
                            PicturePath = "/images/animals/leeuw.png",
                            Price = 40.0,
                            Type = "Jungle"
                        },
                        new
                        {
                            ID = 11,
                            Name = "olifant",
                            PicturePath = "/images/animals/olifant.png",
                            Price = 90.0,
                            Type = "Jungle"
                        },
                        new
                        {
                            ID = 12,
                            Name = "pingwing",
                            PicturePath = "/images/animals/pingwing.png",
                            Price = 50.0,
                            Type = "Sneeuw"
                        },
                        new
                        {
                            ID = 13,
                            Name = "varken",
                            PicturePath = "/images/animals/varken.png",
                            Price = 30.0,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 14,
                            Name = "zebra",
                            PicturePath = "/images/animals/zebra.png",
                            Price = 40.0,
                            Type = "Jungle"
                        },
                        new
                        {
                            ID = 15,
                            Name = "zeehond",
                            PicturePath = "/images/animals/zeehond.png",
                            Price = 70.0,
                            Type = "Sneeuw"
                        });
                });

            modelBuilder.Entity("BeestjeOpJeFeestje.Models.Booking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Booking");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Date = new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("BeestjeOpJeFeestje.Models.BookingAnimal", b =>
                {
                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.HasKey("AnimalId", "BookingId");

                    b.HasIndex("BookingId");

                    b.ToTable("BookingAnimal");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            BookingId = 1
                        },
                        new
                        {
                            AnimalId = 4,
                            BookingId = 1
                        },
                        new
                        {
                            AnimalId = 9,
                            BookingId = 1
                        });
                });

            modelBuilder.Entity("BeestjeOpJeFeestje.Models.Accessories", b =>
                {
                    b.HasOne("BeestjeOpJeFeestje.Models.Animal", "Animal")
                        .WithMany("Accessories")
                        .HasForeignKey("AnimalId");
                });

            modelBuilder.Entity("BeestjeOpJeFeestje.Models.BookingAnimal", b =>
                {
                    b.HasOne("BeestjeOpJeFeestje.Models.Animal", "Animal")
                        .WithMany("BookingAnimal")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeestjeOpJeFeestje.Models.Booking", "Booking")
                        .WithMany("BookingAnimals")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
