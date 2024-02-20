﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Variable.DataAccess.Data;

#nullable disable

namespace Variable.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240113023442_addImageurltoProduct")]
    partial class addImageurltoProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Variable.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Phones"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Laptops"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Pc components"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Phone Accessories"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Pc & Laptop Accessories"
                        });
                });

            modelBuilder.Entity("Variable.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("DisccountPrice")
                        .HasColumnType("double");

                    b.Property<string>("ImageURl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Apple",
                            CategoryId = 1,
                            Color = "Natural Titanium",
                            Description1 = "iPhone 15 Pro has a strong and light aerospace-grade titanium design with a textured matte-glass back. It also features a Ceramic Shield front that’s tougher than any smartphone glass.",
                            Description2 = "The 6.1” Super Retina XDR display with ProMotion ramps up refresh rates to 120Hz when you need exceptional graphics performance. ",
                            Description3 = "A Pro-class GPU makes mobile games feel so immersive, with rich environments and realistic characters. ",
                            DisccountPrice = 130499.0,
                            ImageURl = "",
                            Price = 134900.0,
                            ProductName = "iPhone 15 Pro",
                            Storage = "256 GB"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Asus",
                            CategoryId = 2,
                            Color = "Black",
                            Description1 = "Processor: IntelCore i3-1215U Processor 1.2 GHz (10M Cache, up to 4.4 GHz, 6 cores).",
                            Description2 = "Memory: 8GB DDR4 on board 3200MHz with | Storage: 512GB M.2 NVMe PCIe 4.0 SSD. ",
                            Description3 = "I/O Port: 1x USB 2.0 Type-A, 1x USB 3.2 Gen 1 Type-C, 2x USB 3.2 Gen 1 Type-A, 1x HDMI 1.4, 1x 3.5mm Combo Audio Jack, 1x DC-in.",
                            DisccountPrice = 37990.0,
                            ImageURl = "",
                            Price = 55990.0,
                            ProductName = "ASUS Vivobook 16",
                            Storage = "512 GB SSD"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Samsung",
                            CategoryId = 1,
                            Color = "Dark Red",
                            Description1 = "The first Galaxy S with embedded S Pen. Write comfortably like pen on paper, turn quick notes into legible text and use Air Actions to control your phone remotely.",
                            Description2 = "5G Ready powered by Galaxy’s first 4nm processor. Our fastest, most powerful chip ever.",
                            Description3 = "The Dynamic AMOLED 2x display improves outdoor visibility with up to 1750 nits in peak brightness.* And the 120Hz adaptive refresh rate keeps the scroll smooth, adjusting to what's on screen for an optimized view.",
                            DisccountPrice = 84499.0,
                            ImageURl = "",
                            Price = 131900.0,
                            ProductName = "Samsung Galaxy S22 Ultra 5G",
                            Storage = "256 GB"
                        });
                });

            modelBuilder.Entity("Variable.Models.Product", b =>
                {
                    b.HasOne("Variable.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
