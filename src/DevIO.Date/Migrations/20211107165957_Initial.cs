using Microsoft.EntityFrameworkCore.Migrations;

namespace DevIO.Date.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereçõs_Fornecedores_FornecedorId",
                table: "Endereçõs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereçõs",
                table: "Endereçõs");

            migrationBuilder.RenameTable(
                name: "Endereçõs",
                newName: "Endereços");

            migrationBuilder.RenameIndex(
                name: "IX_Endereçõs_FornecedorId",
                table: "Endereços",
                newName: "IX_Endereços_FornecedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereços",
                table: "Endereços",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereços_Fornecedores_FornecedorId",
                table: "Endereços",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereços_Fornecedores_FornecedorId",
                table: "Endereços");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereços",
                table: "Endereços");

            migrationBuilder.RenameTable(
                name: "Endereços",
                newName: "Endereçõs");

            migrationBuilder.RenameIndex(
                name: "IX_Endereços_FornecedorId",
                table: "Endereçõs",
                newName: "IX_Endereçõs_FornecedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereçõs",
                table: "Endereçõs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereçõs_Fornecedores_FornecedorId",
                table: "Endereçõs",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
