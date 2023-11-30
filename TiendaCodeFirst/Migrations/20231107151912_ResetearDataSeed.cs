using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaCodeFirst.Migrations
{
    public partial class ResetearDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "PedidoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "PedidoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6222), new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 2,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6228), new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6232), new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 4,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6235), new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 5,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6238), new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 6,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6241), new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 1,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 3,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 4,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 5,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 6,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 7, 15, 19, 11, 787, DateTimeKind.Utc).AddTicks(6662));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "PedidoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "PedidoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1203), new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 2,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1209), new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1214), new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 4,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1218), new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 5,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1222), new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 6,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1225), new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 1,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 3,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 4,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 5,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 6,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 7, 10, 24, 33, 30, DateTimeKind.Utc).AddTicks(1623));
        }
    }
}
