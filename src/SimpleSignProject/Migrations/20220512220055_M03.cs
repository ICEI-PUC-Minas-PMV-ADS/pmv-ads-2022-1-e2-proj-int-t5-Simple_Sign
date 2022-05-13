using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSign.Migrations
{
    public partial class M03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssinaturaId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DocumentoModelId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAssinatura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusDoc = table.Column<bool>(type: "bit", nullable: false),
                    QtdeDevolutivas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assinaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentoModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assinaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assinaturas_Documentos_DocumentoModelId",
                        column: x => x.DocumentoModelId,
                        principalTable: "Documentos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_AssinaturaId",
                table: "Usuarios",
                column: "AssinaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_DocumentoModelId",
                table: "Usuarios",
                column: "DocumentoModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Assinaturas_DocumentoModelId",
                table: "Assinaturas",
                column: "DocumentoModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Assinaturas_AssinaturaId",
                table: "Usuarios",
                column: "AssinaturaId",
                principalTable: "Assinaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Documentos_DocumentoModelId",
                table: "Usuarios",
                column: "DocumentoModelId",
                principalTable: "Documentos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Assinaturas_AssinaturaId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Documentos_DocumentoModelId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Assinaturas");

            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_AssinaturaId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_DocumentoModelId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "AssinaturaId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DocumentoModelId",
                table: "Usuarios");
        }
    }
}
