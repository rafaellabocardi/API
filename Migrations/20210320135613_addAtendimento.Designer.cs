﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api;

namespace api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210320135613_addAtendimento")]
    partial class addAtendimento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("api.Atendimento", b =>
                {
                    b.Property<int>("AtendimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Data")
                        .HasColumnType("integer");

                    b.Property<int?>("PetId")
                        .HasColumnType("integer");

                    b.Property<double>("Preco")
                        .HasColumnType("double precision");

                    b.Property<int>("numAtendimentos")
                        .HasColumnType("integer");

                    b.HasKey("AtendimentoId");

                    b.HasIndex("PetId");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("api.DonoPet", b =>
                {
                    b.Property<int>("DonoPetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int?>("PetId")
                        .HasColumnType("integer");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.HasKey("DonoPetId");

                    b.HasIndex("PetId");

                    b.ToTable("DonoPets");
                });

            modelBuilder.Entity("api.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Porte")
                        .HasColumnType("text");

                    b.Property<string>("Tipo")
                        .HasColumnType("text");

                    b.HasKey("PetId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("api.Atendimento", b =>
                {
                    b.HasOne("api.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("api.DonoPet", b =>
                {
                    b.HasOne("api.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId");

                    b.Navigation("Pet");
                });
#pragma warning restore 612, 618
        }
    }
}
