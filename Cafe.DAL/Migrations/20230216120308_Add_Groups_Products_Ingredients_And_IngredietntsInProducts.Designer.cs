// <auto-generated />
using System;
using Cafe.DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cafe.DAL.Migrations
{
    [DbContext(typeof(CafeDbContext))]
    [Migration("20230216120308_Add_Groups_Products_Ingredients_And_IngredietntsInProducts")]
    partial class AddGroupsProductsIngredientsAndIngredietntsInProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cafe.DAL.Entities.GroupProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("GroupProducts");
                });

            modelBuilder.Entity("Cafe.DAL.Entities.Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GroupProductId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("GroupProductId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Cafe.DAL.Entities.IngredientsInProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("ProductId");

                    b.ToTable("IngredientsInProducts");
                });

            modelBuilder.Entity("Cafe.DAL.Entities.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("GroupId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Price")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Cafe.DAL.Entities.Ingredients", b =>
                {
                    b.HasOne("Cafe.DAL.Entities.GroupProducts", "GroupProduct")
                        .WithMany("Ingredients")
                        .HasForeignKey("GroupProductId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("GroupProduct");
                });

            modelBuilder.Entity("Cafe.DAL.Entities.IngredientsInProducts", b =>
                {
                    b.HasOne("Cafe.DAL.Entities.Ingredients", "Ingredient")
                        .WithMany("IngredientsInProducts")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cafe.DAL.Entities.Products", "Product")
                        .WithMany("Ingredients")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Cafe.DAL.Entities.Products", b =>
                {
                    b.HasOne("Cafe.DAL.Entities.GroupProducts", "Group")
                        .WithMany("Products")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Cafe.DAL.Entities.GroupProducts", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Cafe.DAL.Entities.Ingredients", b =>
                {
                    b.Navigation("IngredientsInProducts");
                });

            modelBuilder.Entity("Cafe.DAL.Entities.Products", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
