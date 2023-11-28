using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoList.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "attivita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titolo = table.Column<string>(type: "TEXT", nullable: false),
                    Testo = table.Column<string>(type: "TEXT", nullable: false),
                    IdUtCreazione = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCreazione = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataUltModifica = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Completato = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attivita", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "utenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    UltimoAccesso = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utenti", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attivita");

            migrationBuilder.DropTable(
                name: "utenti");
        }
    }
}
