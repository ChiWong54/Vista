﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vista.App.Data;

#nullable disable

namespace Vista.App.Data.Migrations
{
    [DbContext(typeof(TrainersDbContext))]
    partial class TrainersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Vista.App.Data.Category", b =>
                {
                    b.Property<string>("CategoryCode")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryCode");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryCode = "IT",
                            CategoryName = "Information Technology"
                        },
                        new
                        {
                            CategoryCode = "HS",
                            CategoryName = "Health and Safety"
                        },
                        new
                        {
                            CategoryCode = "LM",
                            CategoryName = "Leadership and Management"
                        },
                        new
                        {
                            CategoryCode = "ED",
                            CategoryName = "Equality and Diversity"
                        },
                        new
                        {
                            CategoryCode = "MAR",
                            CategoryName = "Marketing"
                        });
                });

            modelBuilder.Entity("Vista.App.Data.Session", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BookingReference")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SessionDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("TrainerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SessionId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            SessionId = 1,
                            SessionDate = new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 1
                        },
                        new
                        {
                            SessionId = 2,
                            SessionDate = new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 1
                        },
                        new
                        {
                            SessionId = 3,
                            SessionDate = new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 1
                        },
                        new
                        {
                            SessionId = 4,
                            SessionDate = new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 1
                        },
                        new
                        {
                            SessionId = 5,
                            BookingReference = "TST-99",
                            SessionDate = new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 1
                        },
                        new
                        {
                            SessionId = 6,
                            SessionDate = new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 1
                        },
                        new
                        {
                            SessionId = 7,
                            SessionDate = new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 1
                        },
                        new
                        {
                            SessionId = 8,
                            SessionDate = new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 1
                        },
                        new
                        {
                            SessionId = 9,
                            SessionDate = new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 1
                        },
                        new
                        {
                            SessionId = 10,
                            SessionDate = new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 1
                        },
                        new
                        {
                            SessionId = 11,
                            SessionDate = new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 2
                        },
                        new
                        {
                            SessionId = 12,
                            SessionDate = new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 2
                        },
                        new
                        {
                            SessionId = 13,
                            SessionDate = new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 2
                        },
                        new
                        {
                            SessionId = 14,
                            SessionDate = new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 2
                        },
                        new
                        {
                            SessionId = 15,
                            SessionDate = new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 2
                        },
                        new
                        {
                            SessionId = 16,
                            BookingReference = "TST-98",
                            SessionDate = new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 2
                        },
                        new
                        {
                            SessionId = 17,
                            BookingReference = "TST-97",
                            SessionDate = new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 2
                        },
                        new
                        {
                            SessionId = 18,
                            SessionDate = new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 2
                        },
                        new
                        {
                            SessionId = 19,
                            SessionDate = new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 2
                        },
                        new
                        {
                            SessionId = 20,
                            SessionDate = new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 2
                        },
                        new
                        {
                            SessionId = 21,
                            SessionDate = new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 3
                        },
                        new
                        {
                            SessionId = 22,
                            SessionDate = new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 3
                        },
                        new
                        {
                            SessionId = 23,
                            SessionDate = new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 3
                        },
                        new
                        {
                            SessionId = 24,
                            BookingReference = "TST-96",
                            SessionDate = new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 3
                        },
                        new
                        {
                            SessionId = 25,
                            SessionDate = new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 3
                        },
                        new
                        {
                            SessionId = 26,
                            SessionDate = new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 3
                        },
                        new
                        {
                            SessionId = 27,
                            SessionDate = new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 3
                        },
                        new
                        {
                            SessionId = 28,
                            SessionDate = new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 3
                        },
                        new
                        {
                            SessionId = 29,
                            SessionDate = new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 3
                        },
                        new
                        {
                            SessionId = 30,
                            BookingReference = "TST-94",
                            SessionDate = new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 3
                        },
                        new
                        {
                            SessionId = 31,
                            SessionDate = new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 4
                        },
                        new
                        {
                            SessionId = 32,
                            SessionDate = new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 4
                        },
                        new
                        {
                            SessionId = 33,
                            BookingReference = "TST-95",
                            SessionDate = new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 4
                        },
                        new
                        {
                            SessionId = 34,
                            SessionDate = new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 4
                        },
                        new
                        {
                            SessionId = 35,
                            SessionDate = new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 4
                        },
                        new
                        {
                            SessionId = 36,
                            SessionDate = new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerId = 4
                        });
                });

            modelBuilder.Entity("Vista.App.Data.Trainer", b =>
                {
                    b.Property<int>("TrainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("TrainerId");

                    b.ToTable("Trainers");

                    b.HasData(
                        new
                        {
                            TrainerId = 1,
                            Location = "Middlesbrough",
                            Name = "Palmer Patel"
                        },
                        new
                        {
                            TrainerId = 2,
                            Location = "Stockton-on-Tees",
                            Name = "Cater Moon"
                        },
                        new
                        {
                            TrainerId = 3,
                            Location = "Middlesbrough",
                            Name = "Alex Dickerson"
                        },
                        new
                        {
                            TrainerId = 4,
                            Location = "Stockton-on-Tees",
                            Name = "Sally Johnson"
                        });
                });

            modelBuilder.Entity("Vista.App.Data.TrainerCategory", b =>
                {
                    b.Property<int>("TrainerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryCode")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("TrainerId", "CategoryCode");

                    b.HasIndex("CategoryCode");

                    b.ToTable("TrainerCategories");

                    b.HasData(
                        new
                        {
                            TrainerId = 1,
                            CategoryCode = "IT"
                        },
                        new
                        {
                            TrainerId = 1,
                            CategoryCode = "ED"
                        },
                        new
                        {
                            TrainerId = 2,
                            CategoryCode = "LM"
                        },
                        new
                        {
                            TrainerId = 2,
                            CategoryCode = "HS"
                        },
                        new
                        {
                            TrainerId = 2,
                            CategoryCode = "ED"
                        },
                        new
                        {
                            TrainerId = 3,
                            CategoryCode = "IT"
                        },
                        new
                        {
                            TrainerId = 3,
                            CategoryCode = "LM"
                        });
                });

            modelBuilder.Entity("Vista.App.Data.Session", b =>
                {
                    b.HasOne("Vista.App.Data.Trainer", "Trainer")
                        .WithMany("Sessions")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Vista.App.Data.TrainerCategory", b =>
                {
                    b.HasOne("Vista.App.Data.Category", "Category")
                        .WithMany("TrainerCategories")
                        .HasForeignKey("CategoryCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Vista.App.Data.Trainer", "Trainer")
                        .WithMany("TrainerCategories")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Vista.App.Data.Category", b =>
                {
                    b.Navigation("TrainerCategories");
                });

            modelBuilder.Entity("Vista.App.Data.Trainer", b =>
                {
                    b.Navigation("Sessions");

                    b.Navigation("TrainerCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
