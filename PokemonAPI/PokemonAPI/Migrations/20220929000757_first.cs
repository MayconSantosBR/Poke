using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PokemonAPI.Migrations
{
    public partial class first : Migration
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
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
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
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    EffectId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilities", x => x.IdHability);
                    table.ForeignKey(
                        name: "FK_Habilities_Effects_EffectId",
                        column: x => x.EffectId,
                        principalTable: "Effects",
                        principalColumn: "IdEffect",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Habilities_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonPokemonType",
                columns: table => new
                {
                    PokemonsIdPokemon = table.Column<long>(type: "bigint", nullable: false),
                    TypesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonPokemonType", x => new { x.PokemonsIdPokemon, x.TypesId });
                    table.ForeignKey(
                        name: "FK_PokemonPokemonType_Pokemons_PokemonsIdPokemon",
                        column: x => x.PokemonsIdPokemon,
                        principalTable: "Pokemons",
                        principalColumn: "IdPokemon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonPokemonType_Types_TypesId",
                        column: x => x.TypesId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonPokemonTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPokemon = table.Column<long>(type: "bigint", nullable: false),
                    PokemonIdPokemon = table.Column<long>(type: "bigint", nullable: false),
                    IdType = table.Column<long>(type: "bigint", nullable: false),
                    PokemonTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonPokemonTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonPokemonTypes_Pokemons_PokemonIdPokemon",
                        column: x => x.PokemonIdPokemon,
                        principalTable: "Pokemons",
                        principalColumn: "IdPokemon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonPokemonTypes_Types_PokemonTypeId",
                        column: x => x.PokemonTypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HabilityPokemon",
                columns: table => new
                {
                    HabilitiesIdHability = table.Column<long>(type: "bigint", nullable: false),
                    PokemonsIdPokemon = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilityPokemon", x => new { x.HabilitiesIdHability, x.PokemonsIdPokemon });
                    table.ForeignKey(
                        name: "FK_HabilityPokemon_Habilities_HabilitiesIdHability",
                        column: x => x.HabilitiesIdHability,
                        principalTable: "Habilities",
                        principalColumn: "IdHability",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HabilityPokemon_Pokemons_PokemonsIdPokemon",
                        column: x => x.PokemonsIdPokemon,
                        principalTable: "Pokemons",
                        principalColumn: "IdPokemon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonHability",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPokemon = table.Column<long>(type: "bigint", nullable: false),
                    PokemonIdPokemon = table.Column<long>(type: "bigint", nullable: false),
                    IdHability = table.Column<long>(type: "bigint", nullable: false),
                    HabilityIdHability = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonHability", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonHability_Habilities_HabilityIdHability",
                        column: x => x.HabilityIdHability,
                        principalTable: "Habilities",
                        principalColumn: "IdHability",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonHability_Pokemons_PokemonIdPokemon",
                        column: x => x.PokemonIdPokemon,
                        principalTable: "Pokemons",
                        principalColumn: "IdPokemon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habilities_EffectId",
                table: "Habilities",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Habilities_TypeId",
                table: "Habilities",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HabilityPokemon_PokemonsIdPokemon",
                table: "HabilityPokemon",
                column: "PokemonsIdPokemon");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonHability_HabilityIdHability",
                table: "PokemonHability",
                column: "HabilityIdHability");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonHability_PokemonIdPokemon",
                table: "PokemonHability",
                column: "PokemonIdPokemon");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonPokemonType_TypesId",
                table: "PokemonPokemonType",
                column: "TypesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonPokemonTypes_PokemonIdPokemon",
                table: "PokemonPokemonTypes",
                column: "PokemonIdPokemon");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonPokemonTypes_PokemonTypeId",
                table: "PokemonPokemonTypes",
                column: "PokemonTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HabilityPokemon");

            migrationBuilder.DropTable(
                name: "PokemonHability");

            migrationBuilder.DropTable(
                name: "PokemonPokemonType");

            migrationBuilder.DropTable(
                name: "PokemonPokemonTypes");

            migrationBuilder.DropTable(
                name: "Habilities");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Effects");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
