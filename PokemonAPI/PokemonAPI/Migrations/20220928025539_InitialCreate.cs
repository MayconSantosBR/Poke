using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PokemonAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Effects",
                columns: table => new
                {
                    IdEffect = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Effects", x => x.IdEffect);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    IdPokemon = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.IdPokemon);
                });

            migrationBuilder.CreateTable(
                name: "Habilities",
                columns: table => new
                {
                    IdHability = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Power = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PokemonIdPokemon = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilities", x => x.IdHability);
                    table.ForeignKey(
                        name: "FK_Habilities_Pokemons_PokemonIdPokemon",
                        column: x => x.PokemonIdPokemon,
                        principalTable: "Pokemons",
                        principalColumn: "IdPokemon");
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PokemonIdPokemon = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Types_Pokemons_PokemonIdPokemon",
                        column: x => x.PokemonIdPokemon,
                        principalTable: "Pokemons",
                        principalColumn: "IdPokemon");
                });

            migrationBuilder.CreateTable(
                name: "PokemonHability",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPokemon = table.Column<long>(type: "bigint", nullable: false),
                    IdHability = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonHability", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonHability_Habilities_IdHability",
                        column: x => x.IdHability,
                        principalTable: "Habilities",
                        principalColumn: "IdHability",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonHability_Pokemons_IdPokemon",
                        column: x => x.IdPokemon,
                        principalTable: "Pokemons",
                        principalColumn: "IdPokemon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonPokemonTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPokemon = table.Column<long>(type: "bigint", nullable: false),
                    IdType = table.Column<long>(type: "bigint", nullable: false),
                    PokemonIdPokemon1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonPokemonTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonPokemonTypes_Pokemons_IdPokemon",
                        column: x => x.IdPokemon,
                        principalTable: "Pokemons",
                        principalColumn: "IdPokemon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonPokemonTypes_Pokemons_PokemonIdPokemon1",
                        column: x => x.PokemonIdPokemon1,
                        principalTable: "Pokemons",
                        principalColumn: "IdPokemon");
                    table.ForeignKey(
                        name: "FK_PokemonPokemonTypes_Types_IdType",
                        column: x => x.IdType,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habilities_PokemonIdPokemon",
                table: "Habilities",
                column: "PokemonIdPokemon");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonHability_IdHability",
                table: "PokemonHability",
                column: "IdHability");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonHability_IdPokemon",
                table: "PokemonHability",
                column: "IdPokemon");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonPokemonTypes_IdPokemon",
                table: "PokemonPokemonTypes",
                column: "IdPokemon");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonPokemonTypes_IdType",
                table: "PokemonPokemonTypes",
                column: "IdType");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonPokemonTypes_PokemonIdPokemon1",
                table: "PokemonPokemonTypes",
                column: "PokemonIdPokemon1");

            migrationBuilder.CreateIndex(
                name: "IX_Types_PokemonIdPokemon",
                table: "Types",
                column: "PokemonIdPokemon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Effects");

            migrationBuilder.DropTable(
                name: "PokemonHability");

            migrationBuilder.DropTable(
                name: "PokemonPokemonTypes");

            migrationBuilder.DropTable(
                name: "Habilities");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
