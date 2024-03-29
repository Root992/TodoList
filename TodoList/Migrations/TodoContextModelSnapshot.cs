﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoList.Models;

#nullable disable

namespace TodoList.Migrations
{
    [DbContext(typeof(TodoContext))]
    partial class TodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("TodoList.Models.Attivita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completato")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCreazione")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataUltModifica")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdUtCreazione")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Testo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titolo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("attivita");
                });

            modelBuilder.Entity("TodoList.Models.Utenti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UltimoAccesso")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("utenti");
                });
#pragma warning restore 612, 618
        }
    }
}
