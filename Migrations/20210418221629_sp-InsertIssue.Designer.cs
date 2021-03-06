// <auto-generated />
using System;
using MVC_CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCCRUD.Migrations
{
    [DbContext(typeof(MVC_CRUDContext))]
    [Migration("20210418221629_sp-InsertIssue")]
    partial class spInsertIssue
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_CRUD.Models.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Notes")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Resolution")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<bool>("Resolved")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ResolvedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SeverityId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SubmittedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SeverityId");

                    b.ToTable("Issue");
                });

            modelBuilder.Entity("MVC_CRUD.Models.Severity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("SeverityName")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("Severity");
                });

            modelBuilder.Entity("MVC_CRUD.Models.Issue", b =>
                {
                    b.HasOne("MVC_CRUD.Models.Severity", "Severity")
                        .WithMany()
                        .HasForeignKey("SeverityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Severity");
                });
#pragma warning restore 612, 618
        }
    }
}
