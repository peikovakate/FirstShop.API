﻿// <auto-generated />
using firstShop.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace firstShop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180113192646_BaseModelsCreated")]
    partial class BaseModelsCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("firstShop.API.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("firstShop.API.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("firstShop.API.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int?>("ProductCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("firstShop.API.Models.Product", b =>
                {
                    b.HasOne("firstShop.API.Models.Category", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
