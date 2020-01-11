﻿// <auto-generated />
using System;
using BeestjeOpJeFeestje.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeestjeOpJeFeestje.Migrations
{
    [DbContext(typeof(BeestjeOpJeFeestjeContext))]
    partial class BeestjeOpJeFeestjeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("AnimalId")
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
                            AnimalId = 1,
                            Name = "Strikje",
                            PicturePath = "/images/accessories/Picture 1.png",
                            Price = 15.0
                        },
                        new
                        {
                            ID = 2,
                            AnimalId = 1,
                            Name = "Strikje Rood",
                            PicturePath = "/images/accessories/Picture 2.png",
                            Price = 15.0
                        },
                        new
                        {
                            ID = 3,
                            AnimalId = 2,
                            Name = "Hoge Hoed",
                            PicturePath = "/images/accessories/Picture 3.png",
                            Price = 30.0
                        },
                        new
                        {
                            ID = 4,
                            AnimalId = 3,
                            Name = "Kerstmuts",
                            PicturePath = "/images/accessories/Picture 4.png",
                            Price = 25.0
                        },
                        new
                        {
                            ID = 5,
                            AnimalId = 4,
                            Name = "Maracas",
                            PicturePath = "/images/accessories/Picture 5.png",
                            Price = 10.0
                        },
                        new
                        {
                            ID = 6,
                            AnimalId = 5,
                            Name = "Hamer",
                            PicturePath = "/images/accessories/Picture 6.png",
                            Price = 3.0
                        },
                        new
                        {
                            ID = 7,
                            AnimalId = 6,
                            Name = "Vleugels",
                            PicturePath = "/images/accessories/Picture 7.png",
                            Price = 40.0
                        },
                        new
                        {
                            ID = 8,
                            AnimalId = 7,
                            Name = "Afro Haar",
                            PicturePath = "/images/accessories/Picture 8.png",
                            Price = 30.0
                        },
                        new
                        {
                            ID = 9,
                            AnimalId = 8,
                            Name = "Wandelstok",
                            PicturePath = "/images/accessories/Picture 9.png",
                            Price = 15.0
                        },
                        new
                        {
                            ID = 10,
                            AnimalId = 9,
                            Name = "Bot",
                            PicturePath = "/images/accessories/Picture 10.png",
                            Price = 1.0
                        },
                        new
                        {
                            ID = 11,
                            AnimalId = 9,
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
                            Name = "Aap",
                            PicturePath = "/images/animals/aap.png",
                            Price = 4.5,
                            Type = "Jungle"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Olifant",
                            PicturePath = "/images/animals/olifant.png",
                            Price = 16.5,
                            Type = "Jungle"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Zebra",
                            PicturePath = "/images/animals/zebra.png",
                            Price = 1.5,
                            Type = "Jungle"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Leeuw",
                            PicturePath = "/images/animals/leeuw.png",
                            Price = 29.5,
                            Type = "Jungle"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Hond",
                            PicturePath = "/images/animals/hond.png",
                            Price = 7.5,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Ezel",
                            PicturePath = "/images/animals/ezel.png",
                            Price = 30.5,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 7,
                            Name = "Koe",
                            PicturePath = "/images/animals/koe.png",
                            Price = 1.75,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 8,
                            Name = "Eend",
                            PicturePath = "/images/animals/eend.png",
                            Price = 0.75,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 9,
                            Name = "Kuiken",
                            PicturePath = "/images/animals/kuiken.png",
                            Price = 3.75,
                            Type = "Boerderij"
                        },
                        new
                        {
                            ID = 10,
                            Name = "Pinguin",
                            PicturePath = "/images/animals/pingwing.png",
                            Price = 40.0,
                            Type = "Sneeuw"
                        },
                        new
                        {
                            ID = 11,
                            Name = "Ijsbeer",
                            PicturePath = "/images/animals/ijsbeer.png",
                            Price = 11.75,
                            Type = "Sneeuw"
                        },
                        new
                        {
                            ID = 12,
                            Name = "Zeehond",
                            PicturePath = "/images/animals/zeehond.png",
                            Price = 23.75,
                            Type = "Sneeuw"
                        },
                        new
                        {
                            ID = 13,
                            Name = "Kameel",
                            PicturePath = "/images/animals/kameel.gif",
                            Price = 55.200000000000003,
                            Type = "Woestijn"
                        },
                        new
                        {
                            ID = 14,
                            Name = "Slang",
                            PicturePath = "/images/animals/slang.png",
                            Price = 11.199999999999999,
                            Type = "Woestijn"
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
                });

            modelBuilder.Entity("BeestjeOpJeFeestje.Models.Accessories", b =>
                {
                    b.HasOne("BeestjeOpJeFeestje.Models.Animal", "Animal")
                        .WithMany("Accessories")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
