﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGEP.Migrations
{
    public partial class Migracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<ulong>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<ulong>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<decimal>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Unidade = table.Column<string>(nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(27, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projeto",
                columns: table => new
                {
                    Id = table.Column<ulong>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    PrazoEstimado = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projeto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Unidade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlocacaoPossui",
                columns: table => new
                {
                    Quantidade = table.Column<ulong>(nullable: false),
                    CodMaterial = table.Column<ulong>(nullable: false),
                    CodProjeto = table.Column<ulong>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlocacaoPossui", x => new { x.CodMaterial, x.CodProjeto });
                    table.ForeignKey(
                        name: "FK_AlocacaoPossui_Material_CodMaterial",
                        column: x => x.CodMaterial,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlocacaoPossui_Projeto_CodProjeto",
                        column: x => x.CodProjeto,
                        principalTable: "Projeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParticipaProjeto",
                columns: table => new
                {
                    CodFuncionario = table.Column<ulong>(nullable: false),
                    CodProjeto = table.Column<ulong>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipaProjeto", x => new { x.CodFuncionario, x.CodProjeto });
                    table.ForeignKey(
                        name: "FK_ParticipaProjeto_Funcionario_CodFuncionario",
                        column: x => x.CodFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipaProjeto_Projeto_CodProjeto",
                        column: x => x.CodProjeto,
                        principalTable: "Projeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlocacaoPossui_CodProjeto",
                table: "AlocacaoPossui",
                column: "CodProjeto");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipaProjeto_CodProjeto",
                table: "ParticipaProjeto",
                column: "CodProjeto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlocacaoPossui");

            migrationBuilder.DropTable(
                name: "ParticipaProjeto");

            migrationBuilder.DropTable(
                name: "Unidades");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Projeto");
        }
    }
}
