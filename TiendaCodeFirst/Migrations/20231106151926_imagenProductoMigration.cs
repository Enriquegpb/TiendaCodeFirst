using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaCodeFirst.Migrations
{
    public partial class imagenProductoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Productos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "PedidoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "PedidoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1,
                columns: new[] { "FechaAlta", "FechaModificacion", "Imagen" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8880), new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8881), "imagen1.png" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 2,
                columns: new[] { "FechaAlta", "FechaModificacion", "Imagen" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8886), new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8887), "imagen2.png" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3,
                columns: new[] { "FechaAlta", "FechaModificacion", "Imagen" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8890), new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8890), "imagen3.png" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 4,
                columns: new[] { "FechaAlta", "FechaModificacion", "Imagen" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8893), new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8893), "imagen4.png" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 5,
                columns: new[] { "FechaAlta", "FechaModificacion", "Imagen" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8896), new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8896), "imagen5.png" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 6,
                columns: new[] { "FechaAlta", "FechaModificacion", "Imagen" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8899), new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(8899), "imagen6.png" });

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 1,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 3,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 4,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 5,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 6,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 6, 15, 19, 25, 782, DateTimeKind.Utc).AddTicks(9301));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Productos");

            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "IdLog",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "PedidoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "PedidoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(731), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 2,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(738), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(743), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 4,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(747), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 5,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(750), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 6,
                columns: new[] { "FechaAlta", "FechaModificacion" },
                values: new object[] { new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(754), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Recepciones",
                keyColumn: "Referencia",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 1,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 3,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 4,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 5,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "IdVenta",
                keyValue: 6,
                column: "FechaVenta",
                value: new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1272));
        }
    }
}
