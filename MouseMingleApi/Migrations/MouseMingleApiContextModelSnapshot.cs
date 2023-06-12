﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MouseMingleApi.Models;

#nullable disable

namespace MouseMingle.Migrations
{
    [DbContext(typeof(MouseMingleApiContext))]
    partial class MouseMingleApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MouseMingleApi.Models.Interest", b =>
                {
                    b.Property<int>("InterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("InterestId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("MouseMingleApi.Models.Rodent", b =>
                {
                    b.Property<int>("RodentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("ProfilePic")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.HasKey("RodentId");

                    b.ToTable("Rodents");

                    b.HasData(
                        new
                        {
                            RodentId = 1,
                            Age = 43,
                            Location = "Fishermans Warf No.3",
                            Name = "Scorpo Fangoria",
                            ProfilePic = "./imagePath.img",
                            Species = "Rat"
                        },
                        new
                        {
                            RodentId = 2,
                            Age = 33,
                            Location = "In a van down by the river",
                            Name = "Cadder Jenks",
                            ProfilePic = "./imagePath.img",
                            Species = "Rat"
                        },
                        new
                        {
                            RodentId = 3,
                            Age = 3,
                            Location = "hole",
                            Name = "Flippy Twitch",
                            ProfilePic = "./iumagePath.img",
                            Species = "Mouse"
                        });
                });

            modelBuilder.Entity("MouseMingleApi.Models.RodentInterest", b =>
                {
                    b.Property<int>("RodentInterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.Property<int>("RodentId")
                        .HasColumnType("int");

                    b.HasKey("RodentInterestId");

                    b.HasIndex("InterestId");

                    b.HasIndex("RodentId");

                    b.ToTable("RodentInterests");
                });

            modelBuilder.Entity("MouseMingleApi.Models.RodentInterest", b =>
                {
                    b.HasOne("MouseMingleApi.Models.Interest", null)
                        .WithMany("RodentInterests")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MouseMingleApi.Models.Rodent", null)
                        .WithMany("RodentInterests")
                        .HasForeignKey("RodentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MouseMingleApi.Models.Interest", b =>
                {
                    b.Navigation("RodentInterests");
                });

            modelBuilder.Entity("MouseMingleApi.Models.Rodent", b =>
                {
                    b.Navigation("RodentInterests");
                });
#pragma warning restore 612, 618
        }
    }
}
