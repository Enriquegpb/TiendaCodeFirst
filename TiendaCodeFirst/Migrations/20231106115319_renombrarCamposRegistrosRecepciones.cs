using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaCodeFirst.Migrations
{
    public partial class renombrarCamposRegistrosRecepciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    IdMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.IdMarca);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    IdModelo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.IdModelo);
                });

            migrationBuilder.CreateTable(
                name: "Objetos",
                columns: table => new
                {
                    IdObjeto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objetos", x => x.IdObjeto);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdObjeto = table.Column<int>(type: "int", nullable: false),
                    IdMarca = table.Column<int>(type: "int", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    IdModelo = table.Column<int>(type: "int", nullable: false),
                    DescripcionComercial = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DescripcionTecnica = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Pvp = table.Column<double>(type: "float", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    StockMinimo = table.Column<int>(type: "int", nullable: false),
                    Iva = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Marcas_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marcas",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Modelos_IdModelo",
                        column: x => x.IdModelo,
                        principalTable: "Modelos",
                        principalColumn: "IdModelo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Objetos_IdObjeto",
                        column: x => x.IdObjeto,
                        principalTable: "Objetos",
                        principalColumn: "IdObjeto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineasPedido",
                columns: table => new
                {
                    LineaPedidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    Unidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineasPedido", x => x.LineaPedidoId);
                    table.ForeignKey(
                        name: "FK_LineasPedido_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineasPedido_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    IdLog = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    ProductoPedidoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.IdLog);
                    table.ForeignKey(
                        name: "FK_Logs_Productos_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recepciones",
                columns: table => new
                {
                    Referencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    IdProvedor = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CantidadPedida = table.Column<int>(type: "int", nullable: false),
                    CantidadRecibida = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepciones", x => x.Referencia);
                    table.ForeignKey(
                        name: "FK_Recepciones_Productos_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PvpUnitario = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<int>(type: "int", nullable: false),
                    UnidadesVenta = table.Column<int>(type: "int", nullable: false),
                    Importe = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.IdVenta);
                    table.ForeignKey(
                        name: "FK_Ventas_Productos_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "IdCategoria", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Hogar" },
                    { 2, "Deporte" },
                    { 3, "Tecnología" },
                    { 4, "Montaña" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Cliente1" },
                    { 2, "Cliente3" },
                    { 3, "Cliente4" }
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "IdMarca", "Descripcion" },
                values: new object[,]
                {
                    { 1, "HP" },
                    { 2, "Samsung" },
                    { 3, "NIKE" },
                    { 4, "Decathlon" },
                    { 5, "Casio" },
                    { 6, "Leroy Merlin" },
                    { 7, "Auchan" }
                });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "IdModelo", "Descripcion" },
                values: new object[,]
                {
                    { 1, "HP Spectre" },
                    { 2, "HP Pavilion" },
                    { 3, "HP Envy" },
                    { 4, "Galaxy Note" },
                    { 5, "Galaxy Z Flip" },
                    { 6, "Galaxy S" },
                    { 7, "Galaxy A" },
                    { 8, "Casio FX-991SPX" },
                    { 9, "Casio fx-82MS" },
                    { 10, "Leggins" },
                    { 11, "Pantalón mom jean" },
                    { 12, "Pantalón joggers" },
                    { 13, "cuello redondo" },
                    { 14, "cuello ancho" },
                    { 15, "polos" },
                    { 16, "Nike Air Max 95 Ultra" },
                    { 17, "Nike Go FlyEase" },
                    { 18, "Nike Wearallday" },
                    { 19, "ADIDAS N-5923" },
                    { 20, "ADIDAS NMD" },
                    { 21, "ADIDAS SWIFT RUN" },
                    { 22, "ADIDAS I-5923" },
                    { 23, "ADIDAS YUNG 96" },
                    { 24, "ADIDAS FALCON" },
                    { 25, "ADIDAS AS 520" },
                    { 26, "ADIDAS ZX 2K BOOST" },
                    { 27, "ADIDAS NMD V3" },
                    { 28, "ADIDAS ZX22" }
                });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "IdModelo", "Descripcion" },
                values: new object[] { 29, "ADIDAS ADI2000 X" });

            migrationBuilder.InsertData(
                table: "Objetos",
                columns: new[] { "IdObjeto", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Movil" },
                    { 2, "Portátiles" },
                    { 3, "Tienda Campaña" },
                    { 4, "Mesas" },
                    { 5, "Zapatillas" }
                });

            migrationBuilder.InsertData(
                table: "Pedidos",
                columns: new[] { "PedidoId", "ClienteId", "FechaCreacion" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(659) },
                    { 2, 2, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(663) }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Activo", "DescripcionComercial", "DescripcionTecnica", "FechaAlta", "FechaModificacion", "IdCategoria", "IdMarca", "IdModelo", "IdObjeto", "Iva", "Pvp", "Stock", "StockMinimo" },
                values: new object[,]
                {
                    { 1, true, "Mi descripcion Comercial", "Mi descripcion Tecnica", new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(731), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(732), 1, 1, 1, 1, 15, 5.0, 4, 7 },
                    { 2, false, "Mi descripcion Comercial", "Mi descripcion Tecnica", new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(738), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(739), 2, 2, 2, 2, 9, 3.0, 4, 2 },
                    { 3, true, "Tiene un capacidad de dos personas, ideal para campementos....", "Tiene un volumen de 5 cubicos, guia de motaje fácil.... ", new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(743), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(743), 3, 3, 3, 3, 7, 12.0, 4, 2 },
                    { 4, true, "Te lo puedes llevar a la montaña de vacaciones a otras ciudades...", "Producto de laraga duracion que tiene mucha autonomia y de las mejores prestaciones tecnologicas ", new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(747), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(747), 4, 4, 4, 4, 3, 2.0, 4, 3 },
                    { 5, true, "Todos los clientes esstan muy satisfechos con el producto, algunos hasta consideran que tiene demasiona para lo que es....", "Este producto ofrece todas las mejores prestaciones de la tecnología actual....", new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(750), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(751), 3, 5, 5, 4, 22, 2.0, 4, 6 },
                    { 6, true, "Folios de papel blancos para imprimir de oficiona de 80 g de grosor....", "Folios de papel blancos para imprimir, colegio, hacer manualidades....  ", new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(754), new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(755), 1, 7, 6, 4, 15, 2.0, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "LineasPedido",
                columns: new[] { "LineaPedidoId", "PedidoId", "ProductoId", "Unidades" },
                values: new object[,]
                {
                    { 1, 1, 1, 10 },
                    { 2, 2, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "IdLog", "Cantidad", "Categoria", "FechaRegistro", "IdProducto", "Marca", "ProductoPedidoName" },
                values: new object[,]
                {
                    { 1, 10, "Tecnología", new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1191), 2, "Samsung", "Portátiles" },
                    { 2, 5, "Deporte", new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1196), 6, "Nike", "Zapatos" },
                    { 3, 5, "Montaña", new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1197), 3, "Decathlon", "Tienda Campaña" }
                });

            migrationBuilder.InsertData(
                table: "Recepciones",
                columns: new[] { "Referencia", "CantidadPedida", "CantidadRecibida", "Fecha", "IdProducto", "IdProvedor" },
                values: new object[,]
                {
                    { 1, 15, 15, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1393), 1, 1 },
                    { 2, 15, 15, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1395), 2, 2 },
                    { 3, 40, 40, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1397), 2, 3 },
                    { 4, 60, 60, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1398), 2, 4 },
                    { 5, 80, 80, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1399), 3, 4 },
                    { 6, 25, 25, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1401), 4, 5 },
                    { 7, 40, 40, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1402), 4, 6 }
                });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "IdVenta", "Descuento", "FechaVenta", "IdProducto", "Importe", "PvpUnitario", "UnidadesVenta" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1263), 3, 23.449999999999999, 30.25, 40 },
                    { 2, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 17.989999999999998, 20.5, 20 },
                    { 3, 21, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1268), 2, 30.600000000000001, 38.5, 15 },
                    { 4, 5, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1269), 5, 28.399999999999999, 30.25, 120 },
                    { 5, 7, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1270), 1, 15.199999999999999, 18.75, 45 },
                    { 6, 9, new DateTime(2023, 11, 6, 11, 53, 19, 558, DateTimeKind.Utc).AddTicks(1272), 3, 29.600000000000001, 33.659999999999997, 66 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineasPedido_PedidoId",
                table: "LineasPedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_LineasPedido_ProductoId",
                table: "LineasPedido",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_IdProducto",
                table: "Logs",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdCategoria",
                table: "Productos",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdMarca",
                table: "Productos",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdModelo",
                table: "Productos",
                column: "IdModelo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdObjeto",
                table: "Productos",
                column: "IdObjeto");

            migrationBuilder.CreateIndex(
                name: "IX_Recepciones_IdProducto",
                table: "Recepciones",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_IdProducto",
                table: "Ventas",
                column: "IdProducto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineasPedido");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Recepciones");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Objetos");
        }
    }
}
