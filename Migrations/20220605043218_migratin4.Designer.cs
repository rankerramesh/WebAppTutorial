﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppTutorial.EntityDAL;

namespace WebAppTutorial.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20220605043218_migratin4")]
    partial class migratin4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppTutorial.EntityDAL.PersonInfo", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.HasIndex("PostId");

                    b.ToTable("PersonInfo");
                });

            modelBuilder.Entity("WebAppTutorial.EntityDAL.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("PostId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("WebAppTutorial.EntityDAL.PersonInfo", b =>
                {
                    b.HasOne("WebAppTutorial.EntityDAL.Post", "Post")
                        .WithMany("PersonInfos")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("WebAppTutorial.EntityDAL.Post", b =>
                {
                    b.Navigation("PersonInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
