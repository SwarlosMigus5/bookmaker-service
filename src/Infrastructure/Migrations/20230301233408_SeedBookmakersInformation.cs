using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookmakerService.Infrastructure.Migrations
{
    public partial class SeedBookmakersInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bookmaker",
                columns: new[] { "Id", "BaseUrl", "Comments", "Country", "CreationDate", "Description", "ModificationDate", "Name", "UUId" },
                values: new object[,]
                {
                    { 1L, "https://www.betano.pt/", "", "Portugal", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7597), "Casa de apostas portuguesa Betano.", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7705), "Betano", new Guid("749e2e24-9b1b-4210-ae6d-4275d12c41f7") },
                    { 2L, "https://www.betclic.pt/", "", "Portugal", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7721), "Casa de apostas portuguesa Betclic", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7725), "Betclic", new Guid("ae32838d-2820-4c64-b73b-6bd04c497ec2") },
                    { 3L, "https://www.estorilsolcasinos.pt/pt", "", "Portugal", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7737), "Casa de apostas portuguesa ESC Online", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7741), "ESC Online", new Guid("6521ef65-1c7e-4c35-944d-c864ac16fda6") },
                    { 4L, "https://apostas.solverde.pt/home", "", "Portugal", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7755), "Casa de apostas portuguesa SolVerde", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7758), "SolVerde", new Guid("64a3706f-ba1b-4797-8638-963032550786") },
                    { 5L, "https://www.placard.pt/apostas", "", "Portugal", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7801), "Casa de apostas portuguesa Placard", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7805), "Placard", new Guid("5088765d-b7cf-4752-95d8-d479a8ca554d") },
                    { 6L, "https://www.casinoportugal.pt/", "", "Portugal", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7815), "Casa de apostas portuguesa Casino Portugal", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7819), "Casino Portugal", new Guid("29ec9761-132a-43b2-a541-198196bae977") },
                    { 7L, "https://sports.bwin.pt/pt/sports", "", "Portugal", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7826), "Casa de apostas portuguesa Bwin", new DateTime(2023, 3, 1, 23, 34, 8, 334, DateTimeKind.Local).AddTicks(7830), "Bwin", new Guid("03cd7fc5-79ef-4655-b02b-a1ecddae75e1") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookmaker",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Bookmaker",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Bookmaker",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Bookmaker",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Bookmaker",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Bookmaker",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Bookmaker",
                keyColumn: "Id",
                keyValue: 7L);
        }
    }
}
