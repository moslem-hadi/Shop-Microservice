﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Products.Infrastructure;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20220702053357_init-db")]
    partial class initdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Products.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("BannerUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasDefaultValue("https://via.placeholder.com/500x100.png");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2022, 7, 2, 5, 33, 57, 715, DateTimeKind.Utc).AddTicks(46));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<string>("IconUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasDefaultValue("https://via.placeholder.com/100.png");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime>("ModificationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2022, 7, 2, 5, 33, 57, 715, DateTimeKind.Utc).AddTicks(133));

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = false,
                            BannerUrl = "https://via.placeholder.com/500x200.png",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Aliqua consequat labore elit eiusmod nostrud laborum consequat. Consectetur laborum adipisicing duis ad nulla enim. Esse magna adipisicing fugiat aliqua ea commodo quis anim laboris aliqua fugiat ad. Dolore elit pariatur qui excepteur culpa sit aliqua ea Lorem. Sunt laborum ut sunt cillum reprehenderit do qui nisi.\r\n",
                            Link = "qui",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 1,
                            Title = "veniam"
                        },
                        new
                        {
                            Id = 2,
                            Active = false,
                            BannerUrl = "https://via.placeholder.com/500x200.png",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ut laborum ex laboris do anim adipisicing in adipisicing ea aliquip. In incididunt occaecat do incididunt id sunt eiusmod ut ipsum veniam cupidatat ullamco. Amet non aute cupidatat duis veniam veniam proident in.\r\n",
                            Link = "magna",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 5,
                            Title = "proident"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            BannerUrl = "https://via.placeholder.com/500x200.png",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fugiat dolor qui duis non enim cupidatat eu exercitation Lorem non commodo incididunt ullamco commodo. In tempor ad cillum ad. Id elit aute fugiat nulla pariatur laborum. Nisi sit eiusmod do laborum ex officia duis Lorem aliqua. Tempor magna ipsum nostrud amet labore.\r\n",
                            Link = "eiusmod",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 2,
                            Title = "sunt"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            BannerUrl = "https://via.placeholder.com/500x200.png",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Consectetur adipisicing ex pariatur ex aliquip eu occaecat nulla est. Nostrud voluptate mollit ad duis nulla ullamco laboris. Cillum quis qui minim veniam amet ad laboris exercitation amet. Et cillum fugiat officia in labore aliquip tempor occaecat. Anim ut fugiat nisi sit enim. Adipisicing consectetur elit non eu adipisicing.\r\n",
                            Link = "voluptate",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 7,
                            Title = "aute"
                        },
                        new
                        {
                            Id = 5,
                            Active = false,
                            BannerUrl = "https://via.placeholder.com/500x200.png",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Anim amet esse adipisicing ut nostrud Lorem exercitation anim anim. Excepteur aliqua qui eu sint cillum consequat quis irure. Dolor amet reprehenderit nulla sunt velit occaecat est. Nisi ut ipsum pariatur reprehenderit.\r\n",
                            Link = "qui",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 9,
                            Title = "occaecat"
                        },
                        new
                        {
                            Id = 6,
                            Active = false,
                            BannerUrl = "https://via.placeholder.com/500x200.png",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Aliquip quis aute occaecat proident magna et excepteur. Consectetur magna ut Lorem ut excepteur labore ipsum. Laborum veniam do sunt cupidatat anim mollit exercitation esse consequat excepteur duis excepteur.\r\n",
                            Link = "ipsum",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = 4,
                            Title = "do"
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            BannerUrl = "https://via.placeholder.com/500x200.png",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Amet tempor ex fugiat velit aliquip id commodo eiusmod ad eiusmod aute anim. Exercitation incididunt est duis esse ex Lorem ea nulla anim est labore cupidatat aute. Ea ipsum id reprehenderit esse veniam velit magna aute laboris consectetur tempor occaecat. Incididunt officia laborum incididunt laboris.\r\n",
                            Link = "enim",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 2,
                            Priority = 10,
                            Title = "laborum"
                        },
                        new
                        {
                            Id = 8,
                            Active = false,
                            BannerUrl = "https://via.placeholder.com/500x200.png",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum deserunt pariatur sunt incididunt reprehenderit enim et consectetur nulla sunt. Officia eiusmod culpa deserunt non aliquip laboris in laborum ullamco est dolore in esse. Aliquip qui dolor in irure excepteur et sunt ea duis proident aliqua adipisicing sint. Mollit sit et do excepteur.\r\n",
                            Link = "do",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 2,
                            Priority = 7,
                            Title = "tempor"
                        },
                        new
                        {
                            Id = 9,
                            Active = false,
                            BannerUrl = "https://via.placeholder.com/500x200.png",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum deserunt pariatur sunt incididunt reprehenderit enim et consectetur nulla sunt. Officia eiusmod culpa deserunt non aliquip laboris in laborum ullamco est dolore in esse. Aliquip qui dolor in irure excepteur et sunt ea duis proident aliqua adipisicing sint. Mollit sit et do excepteur.\r\n",
                            Link = "do",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 2,
                            Priority = 7,
                            Title = "consectetur"
                        },
                        new
                        {
                            Id = 10,
                            Active = false,
                            BannerUrl = "https://via.placeholder.com/500x200.png",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum deserunt pariatur sunt incididunt reprehenderit enim et consectetur nulla sunt. Officia eiusmod culpa deserunt non aliquip laboris in laborum ullamco est dolore in esse. Aliquip qui dolor in irure excepteur et sunt ea duis proident aliqua adipisicing sint. Mollit sit et do excepteur.\r\n",
                            Link = "do",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 3,
                            Priority = 7,
                            Title = "Non commodo"
                        });
                });

            modelBuilder.Entity("Products.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2022, 7, 2, 5, 33, 57, 714, DateTimeKind.Utc).AddTicks(9371));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://via.placeholder.com/150x150.png");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("ModificationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2022, 7, 2, 5, 33, 57, 714, DateTimeKind.Utc).AddTicks(9505));

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Products.Domain.Category", b =>
                {
                    b.HasOne("Products.Domain.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("Products.Domain.Product", b =>
                {
                    b.HasOne("Products.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Products.Domain.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}