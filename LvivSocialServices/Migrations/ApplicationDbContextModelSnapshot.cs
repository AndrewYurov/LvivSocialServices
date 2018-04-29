﻿// <auto-generated />
using LvivSocialServices.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LvivSocialServices.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LvivSocialServices.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("PersonId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("LvivSocialServices.Models.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<string>("Description");

                    b.Property<int?>("PersonId");

                    b.Property<string>("Volunteer");

                    b.HasKey("TaskId");

                    b.HasIndex("PersonId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("LvivSocialServices.Models.Task", b =>
                {
                    b.HasOne("LvivSocialServices.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });
#pragma warning restore 612, 618
        }
    }
}