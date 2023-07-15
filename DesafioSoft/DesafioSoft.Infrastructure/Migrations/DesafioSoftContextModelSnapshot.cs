﻿// <auto-generated />
using DesafioSoft.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesafioSoft.Infrastructure.Migrations
{
    [DbContext(typeof(DesafioSoftContext))]
    partial class DesafioSoftContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DesafioSoft.Core.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "J. K. Rowling",
                            Title = "Harry Potter e a Pedra Filosofal",
                            Year = "1997"
                        },
                        new
                        {
                            Id = 2,
                            Author = "J. K. Rowling",
                            Title = "Harry Potter e a Câmara Secreta",
                            Year = "1998"
                        },
                        new
                        {
                            Id = 3,
                            Author = "J. K. Rowling",
                            Title = "Harry Potter e o Prisioneiro de Azkaban",
                            Year = "1999"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
