using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Manutemovel.Domain.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    MarcaId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    CPFCNPJ = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "ModeloAnos",
                columns: table => new
                {
                    ModeloAnoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Ano = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MarcaId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloAnos", x => x.ModeloAnoId);
                    table.ForeignKey(
                        name: "FK_ModeloAnos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "MarcaId");
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    CarroId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Placa = table.Column<string>(type: "text", nullable: false),
                    AnoFabricacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModeloAnoId = table.Column<Guid>(type: "uuid", nullable: true),
                    UsuarioId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.CarroId);
                    table.ForeignKey(
                        name: "FK_Carros_ModeloAnos_ModeloAnoId",
                        column: x => x.ModeloAnoId,
                        principalTable: "ModeloAnos",
                        principalColumn: "ModeloAnoId");
                    table.ForeignKey(
                        name: "FK_Carros_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "ModeloItems",
                columns: table => new
                {
                    ModeloItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    ModeloAnoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloItems", x => x.ModeloItemId);
                    table.ForeignKey(
                        name: "FK_ModeloItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModeloItems_ModeloAnos_ModeloAnoId",
                        column: x => x.ModeloAnoId,
                        principalTable: "ModeloAnos",
                        principalColumn: "ModeloAnoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historicos",
                columns: table => new
                {
                    HistoricoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CarroId = table.Column<Guid>(type: "uuid", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.HistoricoId);
                    table.ForeignKey(
                        name: "FK_Historicos_Carros_CarroId",
                        column: x => x.CarroId,
                        principalTable: "Carros",
                        principalColumn: "CarroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modalidades",
                columns: table => new
                {
                    ModalidadeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Tipo = table.Column<byte>(type: "smallint", nullable: false),
                    ACadaInspecao = table.Column<int>(type: "integer", nullable: false),
                    VidaUtilDias = table.Column<int>(type: "integer", nullable: false),
                    VidaUtilKM = table.Column<int>(type: "integer", nullable: false),
                    ModeloItemId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidades", x => x.ModalidadeId);
                    table.ForeignKey(
                        name: "FK_Modalidades_ModeloItems_ModeloItemId",
                        column: x => x.ModeloItemId,
                        principalTable: "ModeloItems",
                        principalColumn: "ModeloItemId");
                });

            migrationBuilder.CreateTable(
                name: "HistoricoItems",
                columns: table => new
                {
                    HistoricoItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    Instancia = table.Column<int>(type: "integer", nullable: false),
                    ItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    HistoricoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoItems", x => x.HistoricoItemId);
                    table.ForeignKey(
                        name: "FK_HistoricoItems_Historicos_HistoricoId",
                        column: x => x.HistoricoId,
                        principalTable: "Historicos",
                        principalColumn: "HistoricoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricoItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carros_ModeloAnoId",
                table: "Carros",
                column: "ModeloAnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carros_UsuarioId",
                table: "Carros",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoItems_HistoricoId",
                table: "HistoricoItems",
                column: "HistoricoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoItems_ItemId",
                table: "HistoricoItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_CarroId",
                table: "Historicos",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_UsuarioId",
                table: "Historicos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Modalidades_ModeloItemId",
                table: "Modalidades",
                column: "ModeloItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloAnos_MarcaId",
                table: "ModeloAnos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloItems_ItemId",
                table: "ModeloItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloItems_ModeloAnoId",
                table: "ModeloItems",
                column: "ModeloAnoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoItems");

            migrationBuilder.DropTable(
                name: "Modalidades");

            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "ModeloItems");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ModeloAnos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
