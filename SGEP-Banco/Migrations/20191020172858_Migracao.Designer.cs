﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SGEP_Banco.Contexts;

namespace SGEP_Banco.Migrations
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20191020172858_Migracao")]
    partial class Migracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SGEP_Banco.Models.EntradaDBModel", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<ulong>("MaterialID");

                    b.Property<decimal>("Preco");

                    b.Property<decimal>("Quantidade");

                    b.HasKey("Id");

                    b.ToTable("Entrada");
                });

            modelBuilder.Entity("SGEP_Banco.Models.FuncionarioDBModel", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cargo");

                    b.Property<bool>("Demitido");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("SGEP_Banco.Models.FuncionarioProjetoDBModel", b =>
                {
                    b.Property<ulong>("FuncionarioId");

                    b.Property<ulong>("ProjetoId");

                    b.HasKey("FuncionarioId", "ProjetoId");

                    b.ToTable("FuncionarioProjeto");
                });

            modelBuilder.Entity("SGEP_Banco.Models.MaterialDBModel", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<decimal>("Preco");

                    b.Property<decimal>("Quantidade");

                    b.Property<string>("Unidade");

                    b.HasKey("Id");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("SGEP_Banco.Models.ProjetoDBModel", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Nome");

                    b.Property<DateTime>("PrazoEstimado");

                    b.HasKey("Id");

                    b.ToTable("Projeto");
                });

            modelBuilder.Entity("SGEP_Banco.Models.ProjetoFinalizadoDBModel", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataFim");

                    b.HasKey("Id");

                    b.ToTable("ProjetoFinalizado");
                });

            modelBuilder.Entity("SGEP_Banco.Models.SaidaDBModel", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<ulong>("FuncionarioID");

                    b.Property<ulong>("MaterialID");

                    b.Property<ulong>("ProjetoID");

                    b.Property<decimal>("Quantidade");

                    b.HasKey("Id");

                    b.ToTable("Saida");
                });
#pragma warning restore 612, 618
        }
    }
}
