﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Verstegen.Models;

namespace Verstegen.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Verstegen.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Verstegen.Models.ArticleAmount", b =>
                {
                    b.Property<int>("ArticleAmountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleId");

                    b.Property<int>("Gram");

                    b.Property<double>("Percentage");

                    b.Property<int>("ReceptId");

                    b.HasKey("ArticleAmountId");

                    b.HasIndex("ArticleId");

                    b.HasIndex("ReceptId");

                    b.ToTable("ArticleAmounts");
                });

            modelBuilder.Entity("Verstegen.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Verstegen.Models.BlogCategory", b =>
                {
                    b.Property<int>("BlogCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId1");

                    b.Property<int>("CategoryId1");

                    b.HasKey("BlogCategoryId");

                    b.HasIndex("BlogId1");

                    b.HasIndex("CategoryId1");

                    b.ToTable("BlogCategorys");
                });

            modelBuilder.Entity("Verstegen.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired();

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("Verstegen.Models.Recept", b =>
                {
                    b.Property<int>("ReceptId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ReceptId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Verstegen.Models.ArticleAmount", b =>
                {
                    b.HasOne("Verstegen.Models.Article", "Article")
                        .WithMany("Amounts")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Verstegen.Models.Recept", "Recept")
                        .WithMany("Articles")
                        .HasForeignKey("ReceptId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Verstegen.Models.BlogCategory", b =>
                {
                    b.HasOne("Verstegen.Models.Blog", "BlogId")
                        .WithMany()
                        .HasForeignKey("BlogId1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Verstegen.Models.Category", "CategoryId")
                        .WithMany()
                        .HasForeignKey("CategoryId1")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
