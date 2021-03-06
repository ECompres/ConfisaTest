// <auto-generated />
using System;
using ConfisaTest.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConfisaTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210607194842_keyMigrationOficiales")]
    partial class keyMigrationOficiales
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConfisaTest.Models.Dealers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Oficialid")
                        .HasColumnType("int");

                    b.Property<string>("dirección")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<int>("idOficial")
                        .HasColumnType("int");

                    b.Property<string>("rnc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teléfono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Oficialid");

                    b.ToTable("Dealers");
                });

            modelBuilder.Entity("ConfisaTest.Models.Oficiales", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Oficiales");
                });

            modelBuilder.Entity("ConfisaTest.Models.Dealers", b =>
                {
                    b.HasOne("ConfisaTest.Models.Oficiales", "Oficial")
                        .WithMany("Dealers")
                        .HasForeignKey("Oficialid");

                    b.Navigation("Oficial");
                });

            modelBuilder.Entity("ConfisaTest.Models.Oficiales", b =>
                {
                    b.Navigation("Dealers");
                });
#pragma warning restore 612, 618
        }
    }
}
