using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcunmedyaLisesi.Data.Migrations
{
    /// <inheritdoc />
    public partial class ContextOlusturma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bilisims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    SınavId = table.Column<int>(type: "int", nullable: false),
                    EgitimciId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilisims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    SınavId = table.Column<int>(type: "int", nullable: false),
                    EgitimciId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matematiks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    SınavId = table.Column<int>(type: "int", nullable: false),
                    EgitimciId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matematiks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sınavlars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    FenId = table.Column<int>(type: "int", nullable: false),
                    MatematikId = table.Column<int>(type: "int", nullable: false),
                    BilisimId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sınavlars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Egitimcies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatematikId = table.Column<int>(type: "int", nullable: false),
                    FenId = table.Column<int>(type: "int", nullable: false),
                    BilisimId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitimcies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Egitimcies_Bilisims_BilisimId",
                        column: x => x.BilisimId,
                        principalTable: "Bilisims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Egitimcies_Fens_FenId",
                        column: x => x.FenId,
                        principalTable: "Fens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Egitimcies_Matematiks_MatematikId",
                        column: x => x.MatematikId,
                        principalTable: "Matematiks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BilisimSınavlar",
                columns: table => new
                {
                    BilisimId = table.Column<int>(type: "int", nullable: false),
                    SınavlarsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BilisimSınavlar", x => new { x.BilisimId, x.SınavlarsId });
                    table.ForeignKey(
                        name: "FK_BilisimSınavlar_Bilisims_BilisimId",
                        column: x => x.BilisimId,
                        principalTable: "Bilisims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BilisimSınavlar_Sınavlars_SınavlarsId",
                        column: x => x.SınavlarsId,
                        principalTable: "Sınavlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FenSınavlar",
                columns: table => new
                {
                    FenId = table.Column<int>(type: "int", nullable: false),
                    SınavlarsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FenSınavlar", x => new { x.FenId, x.SınavlarsId });
                    table.ForeignKey(
                        name: "FK_FenSınavlar_Fens_FenId",
                        column: x => x.FenId,
                        principalTable: "Fens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FenSınavlar_Sınavlars_SınavlarsId",
                        column: x => x.SınavlarsId,
                        principalTable: "Sınavlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MatematikSınavlar",
                columns: table => new
                {
                    MatematikId = table.Column<int>(type: "int", nullable: false),
                    SınavlarsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatematikSınavlar", x => new { x.MatematikId, x.SınavlarsId });
                    table.ForeignKey(
                        name: "FK_MatematikSınavlar_Matematiks_MatematikId",
                        column: x => x.MatematikId,
                        principalTable: "Matematiks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatematikSınavlar_Sınavlars_SınavlarsId",
                        column: x => x.SınavlarsId,
                        principalTable: "Sınavlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EgitimciId = table.Column<int>(type: "int", nullable: false),
                    MatematikId = table.Column<int>(type: "int", nullable: false),
                    FenId = table.Column<int>(type: "int", nullable: false),
                    BilisimId = table.Column<int>(type: "int", nullable: false),
                    SınavId = table.Column<int>(type: "int", nullable: false),
                    EgitimcilerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrencies_Bilisims_BilisimId",
                        column: x => x.BilisimId,
                        principalTable: "Bilisims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ogrencies_Egitimcies_EgitimcilerId",
                        column: x => x.EgitimcilerId,
                        principalTable: "Egitimcies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ogrencies_Fens_FenId",
                        column: x => x.FenId,
                        principalTable: "Fens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ogrencies_Matematiks_MatematikId",
                        column: x => x.MatematikId,
                        principalTable: "Matematiks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OgrencilerSınavlar",
                columns: table => new
                {
                    OgrencilersId = table.Column<int>(type: "int", nullable: false),
                    SınavlarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrencilerSınavlar", x => new { x.OgrencilersId, x.SınavlarId });
                    table.ForeignKey(
                        name: "FK_OgrencilerSınavlar_Ogrencies_OgrencilersId",
                        column: x => x.OgrencilersId,
                        principalTable: "Ogrencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrencilerSınavlar_Sınavlars_SınavlarId",
                        column: x => x.SınavlarId,
                        principalTable: "Sınavlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BilisimSınavlar_SınavlarsId",
                table: "BilisimSınavlar",
                column: "SınavlarsId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitimcies_BilisimId",
                table: "Egitimcies",
                column: "BilisimId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitimcies_FenId",
                table: "Egitimcies",
                column: "FenId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitimcies_MatematikId",
                table: "Egitimcies",
                column: "MatematikId");

            migrationBuilder.CreateIndex(
                name: "IX_FenSınavlar_SınavlarsId",
                table: "FenSınavlar",
                column: "SınavlarsId");

            migrationBuilder.CreateIndex(
                name: "IX_MatematikSınavlar_SınavlarsId",
                table: "MatematikSınavlar",
                column: "SınavlarsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencies_BilisimId",
                table: "Ogrencies",
                column: "BilisimId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencies_EgitimcilerId",
                table: "Ogrencies",
                column: "EgitimcilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencies_FenId",
                table: "Ogrencies",
                column: "FenId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencies_MatematikId",
                table: "Ogrencies",
                column: "MatematikId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrencilerSınavlar_SınavlarId",
                table: "OgrencilerSınavlar",
                column: "SınavlarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BilisimSınavlar");

            migrationBuilder.DropTable(
                name: "FenSınavlar");

            migrationBuilder.DropTable(
                name: "MatematikSınavlar");

            migrationBuilder.DropTable(
                name: "OgrencilerSınavlar");

            migrationBuilder.DropTable(
                name: "Ogrencies");

            migrationBuilder.DropTable(
                name: "Sınavlars");

            migrationBuilder.DropTable(
                name: "Egitimcies");

            migrationBuilder.DropTable(
                name: "Bilisims");

            migrationBuilder.DropTable(
                name: "Fens");

            migrationBuilder.DropTable(
                name: "Matematiks");
        }
    }
}
