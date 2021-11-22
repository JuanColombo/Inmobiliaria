using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inmobiliaria.Migrations
{
    public partial class Version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    UsuarioId1 = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    TipoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Usuarios_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    Domicilio = table.Column<string>(nullable: false),
                    Cuil = table.Column<double>(nullable: false),
                    Cuit = table.Column<double>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Telefono = table.Column<double>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<int>(nullable: false),
                    Localidad = table.Column<string>(nullable: true),
                    CondicionIva = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    Domicilio = table.Column<string>(nullable: false),
                    Cuil = table.Column<double>(nullable: false),
                    Cuit = table.Column<double>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Telefono = table.Column<double>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<int>(nullable: false),
                    Localidad = table.Column<string>(nullable: true),
                    CondicionIva = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Propietario_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Propiedades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Ubicacion = table.Column<string>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Disponibilidad = table.Column<bool>(nullable: false),
                    PropietarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Propiedades_Propietario_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Propietario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Propiedades_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCompraAlquiler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: false),
                    clienteId = table.Column<int>(nullable: true),
                    IdPropiedad = table.Column<int>(nullable: false),
                    PropiedadesId = table.Column<int>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    PrecioVenta = table.Column<double>(nullable: false),
                    PrecioAlquiler = table.Column<double>(nullable: false),
                    TipoDetalle = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCompraAlquiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleCompraAlquiler_Propiedades_PropiedadesId",
                        column: x => x.PropiedadesId,
                        principalTable: "Propiedades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleCompraAlquiler_Cliente_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Apellido", "CondicionIva", "Cuil", "Cuit", "Dni", "Domicilio", "Eliminado", "Email", "EstadoCivil", "FechaHoraEliminacion", "FechaNacimiento", "Localidad", "Nombre", "Sexo", "Telefono", "UsuarioId" },
                values: new object[,]
                {
                    { 2, "Colombo", 2, 20361962665.0, 0.0, 36196266, "Rafael Bonin 2874", false, "juampicolombosj@gmail.com", 1, null, new DateTime(1992, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Justo", "Juan Pablo", 1, 3498463367.0, null },
                    { 1, "Valle", 3, 20374547144.0, 0.0, 37454714, "Cabal 2608", false, "ivanvallesj@gmail.com", 1, null, new DateTime(1993, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Justo", "Ivan", 1, 3498459297.0, null }
                });

            migrationBuilder.InsertData(
                table: "DetalleCompraAlquiler",
                columns: new[] { "Id", "FechaFin", "FechaInicio", "IdCliente", "IdPropiedad", "PrecioAlquiler", "PrecioVenta", "PropiedadesId", "TipoDetalle", "clienteId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15000.0, 0.0, null, 1, null },
                    { 2, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 0.0, 800000.0, null, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Propietario",
                columns: new[] { "Id", "Apellido", "CondicionIva", "Cuil", "Cuit", "Dni", "Domicilio", "Eliminado", "Email", "EstadoCivil", "FechaHoraEliminacion", "FechaNacimiento", "Localidad", "Nombre", "Sexo", "Telefono", "UsuarioId" },
                values: new object[] { 1, "Parra", 2, 20361962595.0, 0.0, 36196259, "Juan Peron y Urquiza", false, "inmobiliariajuliandaniel@hotmail.com", 1, null, new DateTime(1992, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Justo", "Julian Daniel", 1, 3498526969.0, null });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Eliminado", "FechaHoraEliminacion", "Nombre", "Password", "TipoUsuario", "User", "UsuarioId", "UsuarioId1" },
                values: new object[] { 1, false, null, "Juan Pablo Colombo", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", 1, "juan", null, null });

            migrationBuilder.InsertData(
                table: "Propiedades",
                columns: new[] { "Id", "Disponibilidad", "Eliminado", "FechaHoraEliminacion", "Nombre", "PropietarioId", "Ubicacion", "UsuarioId", "Valor" },
                values: new object[] { 1, true, false, null, "Propiedad 1", 1, "Barrio Parque", null, 1500000.0 });

            migrationBuilder.InsertData(
                table: "Propiedades",
                columns: new[] { "Id", "Disponibilidad", "Eliminado", "FechaHoraEliminacion", "Nombre", "PropietarioId", "Ubicacion", "UsuarioId", "Valor" },
                values: new object[] { 2, true, false, null, "Propiedad 2", 1, "Barrio Levequi", null, 800000.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_UsuarioId",
                table: "Cliente",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompraAlquiler_PropiedadesId",
                table: "DetalleCompraAlquiler",
                column: "PropiedadesId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompraAlquiler_clienteId",
                table: "DetalleCompraAlquiler",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_PropietarioId",
                table: "Propiedades",
                column: "PropietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_UsuarioId",
                table: "Propiedades",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Propietario_UsuarioId",
                table: "Propietario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioId1",
                table: "Usuarios",
                column: "UsuarioId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleCompraAlquiler");

            migrationBuilder.DropTable(
                name: "Propiedades");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Propietario");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
