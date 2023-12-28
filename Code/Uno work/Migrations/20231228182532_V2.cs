using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uno_work.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameStates",
                columns: table => new
                {
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CurrentPlayerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentCardInPlay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrawPile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscardPile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameEnded = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameStates", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "PlayerState",
                columns: table => new
                {
                    PlayerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Hand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameStateGameId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerState", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_PlayerState_GameStates_GameStateGameId",
                        column: x => x.GameStateGameId,
                        principalTable: "GameStates",
                        principalColumn: "GameId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerState_GameStateGameId",
                table: "PlayerState",
                column: "GameStateGameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerState");

            migrationBuilder.DropTable(
                name: "GameStates");
        }
    }
}
