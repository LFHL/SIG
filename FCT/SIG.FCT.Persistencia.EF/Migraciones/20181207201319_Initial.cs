using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIG.FCT.Persistencia.EF.Migraciones
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 30, nullable: false),
                    Direccion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FCT_ActividadesEconomicas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Principal = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Habilitada = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FCT_ActividadesEconomicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FCT_Empresas",
                columns: table => new
                {
                    Nit = table.Column<decimal>(type: "numeric(12, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FCT_Empresas", x => x.Nit);
                });

            migrationBuilder.CreateTable(
                name: "FCT_SistemasFacturacion",
                columns: table => new
                {
                    SFC = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    Fabricante = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FCT_SistemasFacturacion", x => x.SFC);
                });

            migrationBuilder.CreateTable(
                name: "GBL_Direcciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Departamento = table.Column<string>(maxLength: 12, nullable: false),
                    Lugar = table.Column<string>(maxLength: 50, nullable: true),
                    Direccion1 = table.Column<string>(maxLength: 100, nullable: false),
                    Direccion2 = table.Column<string>(maxLength: 100, nullable: true),
                    DireccionDescriptiva = table.Column<string>(maxLength: 250, nullable: true),
                    Pos_X = table.Column<int>(nullable: true),
                    Pos_Y = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GBL_Direcciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GBL_Imagenes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdType = table.Column<int>(nullable: true),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    Imagen = table.Column<byte[]>(type: "image", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GBL_Imagenes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "INV_Compras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    IdUsuario = table.Column<int>(nullable: false),
                    IdProveedor = table.Column<string>(maxLength: 10, nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IdMoneda = table.Column<string>(maxLength: 10, nullable: true),
                    TipoCambio = table.Column<double>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_Compras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PAR_CategoriasProducto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAR_CategoriasProducto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PAR_Generales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTipo = table.Column<int>(nullable: true),
                    Codigo = table.Column<string>(maxLength: 10, nullable: true),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Orden = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    Habilitado = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAR_Generales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FCT_Parametros_FCT_Parametros",
                        column: x => x.IdTipo,
                        principalTable: "PAR_Generales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PAR_TiposObjeto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 12, nullable: false),
                    TablaAsociada = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAR_TiposObjeto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPersonal",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PayRate = table.Column<double>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPersonal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaOrden = table.Column<DateTime>(nullable: false),
                    FechaEntrega = table.Column<DateTime>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ordenes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FCT_Sucursales",
                columns: table => new
                {
                    Numero = table.Column<int>(nullable: false),
                    NombreComercial = table.Column<string>(maxLength: 60, nullable: false),
                    IdDireccion = table.Column<int>(nullable: true),
                    IdLogo = table.Column<int>(nullable: true),
                    Telefonos = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FCT_Sucursales", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_FCT_Sucursales_GBL_Direcciones",
                        column: x => x.IdDireccion,
                        principalTable: "GBL_Direcciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FCT_Sucursales_GBL_Imagenes",
                        column: x => x.IdLogo,
                        principalTable: "GBL_Imagenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_Productos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(maxLength: 10, nullable: true),
                    Nombre = table.Column<string>(maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Precio = table.Column<decimal>(type: "numeric(18, 2)", nullable: false),
                    IdCategoria = table.Column<int>(nullable: false),
                    IdTipoUnidad = table.Column<int>(nullable: false),
                    EsParaVenta = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INV_Productos_PAR_CategoriasProducto",
                        column: x => x.IdCategoria,
                        principalTable: "PAR_CategoriasProducto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GBL_PropiedadesContacto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTipo = table.Column<int>(nullable: false),
                    Valor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GBL_PropiedadesContacto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GBL_DatosContacto_PAR_GENERALES",
                        column: x => x.IdTipo,
                        principalTable: "PAR_Generales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nit = table.Column<decimal>(type: "numeric(12, 0)", nullable: false),
                    RazonSocial = table.Column<string>(maxLength: 100, nullable: false),
                    IdTipoObjeto = table.Column<int>(nullable: true),
                    IdObjeto = table.Column<decimal>(type: "numeric(12, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INV_Clientes_PAR_TiposObjeto",
                        column: x => x.IdTipoObjeto,
                        principalTable: "PAR_TiposObjeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FCT_AsignacionesSistema",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SFC = table.Column<int>(nullable: true),
                    IdActividadEconomica = table.Column<int>(nullable: true),
                    NroSucursal = table.Column<int>(nullable: true),
                    IdTipoEmisor = table.Column<int>(nullable: true),
                    Habilitado = table.Column<bool>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FCT_AsignacionesSistema", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FCT_AsignacionesSistema_FCT_ActividadesEconomicas",
                        column: x => x.IdActividadEconomica,
                        principalTable: "FCT_ActividadesEconomicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FCT_AsignacionesSistema_FCT_Parametros",
                        column: x => x.IdTipoEmisor,
                        principalTable: "PAR_Generales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FCT_AsignacionesSistema_FCT_Sucursales",
                        column: x => x.NroSucursal,
                        principalTable: "FCT_Sucursales",
                        principalColumn: "Numero",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FCT_AsignacionesSistema_FCT_SistemasFacturacion",
                        column: x => x.SFC,
                        principalTable: "FCT_SistemasFacturacion",
                        principalColumn: "SFC",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_DetalleCompras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    IdCompra = table.Column<int>(nullable: false),
                    IdProducto = table.Column<int>(nullable: false),
                    Cantidad = table.Column<short>(nullable: false),
                    CostoUnidad = table.Column<decimal>(type: "numeric(18, 2)", nullable: false),
                    Total = table.Column<decimal>(type: "numeric(24, 2)", nullable: true, computedColumnSql: "([Cantidad]*[CostoUnidad])")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_DetalleCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INV_DetalleCompras_INV_Compras",
                        column: x => x.IdCompra,
                        principalTable: "INV_Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_INV_DetalleCompras_INV_Productos",
                        column: x => x.IdProducto,
                        principalTable: "INV_Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_SubProductos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(nullable: false),
                    IdSubProducto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_SubProductos", x => new { x.IdProducto, x.IdSubProducto });
                    table.ForeignKey(
                        name: "FK_INV_SubProductos_INV_Productos",
                        column: x => x.IdProducto,
                        principalTable: "INV_Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_SubProductos_INV_Productos1",
                        column: x => x.IdSubProducto,
                        principalTable: "INV_Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GBL_Empresas",
                columns: table => new
                {
                    Nit = table.Column<decimal>(type: "numeric(12, 0)", nullable: false),
                    IdTipoSociedad = table.Column<int>(nullable: true),
                    RazonSocial = table.Column<string>(maxLength: 100, nullable: true),
                    MatriculaComercio = table.Column<decimal>(type: "numeric(8, 0)", nullable: true),
                    IdSitioWeb = table.Column<int>(nullable: true),
                    IdTelefonoPrincipal = table.Column<int>(nullable: true),
                    IdDireccion = table.Column<int>(nullable: true),
                    IdLogo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GBL_Empresas", x => x.Nit);
                    table.ForeignKey(
                        name: "FK_GBL_Empresa_GBL_Direcciones",
                        column: x => x.IdDireccion,
                        principalTable: "GBL_Direcciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GBL_Empresa_GBL_Imagenes",
                        column: x => x.IdLogo,
                        principalTable: "GBL_Imagenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GBL_Empresa_GBL_DatosContacto",
                        column: x => x.IdSitioWeb,
                        principalTable: "GBL_PropiedadesContacto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GBL_Empresa_GBL_DatosContacto1",
                        column: x => x.IdTelefonoPrincipal,
                        principalTable: "GBL_PropiedadesContacto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GBL_Personas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NroDocumento = table.Column<string>(maxLength: 20, nullable: true),
                    IdTipoDocumento = table.Column<int>(nullable: true),
                    PrimerNombre = table.Column<string>(maxLength: 120, nullable: true),
                    SegundoNombre = table.Column<string>(maxLength: 10, nullable: true),
                    PrimerApellido = table.Column<string>(maxLength: 10, nullable: true),
                    SegundoApellido = table.Column<string>(maxLength: 10, nullable: true),
                    FechaNacimiento = table.Column<string>(maxLength: 10, nullable: true),
                    IdDireccion = table.Column<int>(nullable: true),
                    IdTelefonoPrincipal = table.Column<int>(nullable: true),
                    IdCorreoPrincipal = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GBL_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GBL_Personas_GBL_Direcciones",
                        column: x => x.IdDireccion,
                        principalTable: "GBL_Direcciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GBL_Personas_GBL_DatosContacto",
                        column: x => x.IdTelefonoPrincipal,
                        principalTable: "GBL_PropiedadesContacto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdVendedor = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IdCliente = table.Column<int>(nullable: false),
                    IdMoneda = table.Column<int>(nullable: false),
                    TipoCambio = table.Column<double>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_Ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INV_Ventas_INV_Clientes",
                        column: x => x.IdCliente,
                        principalTable: "INV_Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_Ventas_PAR_Generales1",
                        column: x => x.IdMoneda,
                        principalTable: "PAR_Generales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FCT_Dosificaciones",
                columns: table => new
                {
                    NroAutorizacion = table.Column<decimal>(type: "numeric(15, 0)", nullable: false),
                    IdAsignacion = table.Column<int>(nullable: false),
                    IdCaracteristicaEspecial = table.Column<int>(nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "date", nullable: true),
                    FechaLimiteEmision = table.Column<DateTime>(type: "date", nullable: true),
                    LeyendaAsignada = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    NroTramite = table.Column<string>(maxLength: 12, nullable: true),
                    Llave = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FCT_Dosificaciones", x => x.NroAutorizacion);
                    table.ForeignKey(
                        name: "FK_FCT_Dosificaciones_FCT_AsignacionesSistema",
                        column: x => x.IdAsignacion,
                        principalTable: "FCT_AsignacionesSistema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INV_DetalleVentas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdVenta = table.Column<int>(nullable: false),
                    IdProducto = table.Column<int>(nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "numeric(18, 2)", nullable: false),
                    Cantidad = table.Column<short>(nullable: false),
                    PctDescuento = table.Column<short>(nullable: false),
                    MontoTotal = table.Column<decimal>(type: "numeric(35, 2)", nullable: true, computedColumnSql: "(([Cantidad]*[PrecioUnitario])*((1)-[PctDescuento]/(100)))"),
                    Comentarios = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INV_DetalleVentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INV_DetalleVentas_INV_Productos",
                        column: x => x.IdProducto,
                        principalTable: "INV_Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INV_DetalleVentas_INV_Ventas",
                        column: x => x.IdVenta,
                        principalTable: "INV_Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FCT_Facturas",
                columns: table => new
                {
                    IdVenta = table.Column<int>(nullable: false),
                    NroAutorizacion = table.Column<decimal>(type: "numeric(15, 0)", nullable: false),
                    Numero = table.Column<decimal>(type: "numeric(10, 0)", nullable: false, defaultValueSql: "((1))"),
                    FechaEmision = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    NitCliente = table.Column<decimal>(type: "numeric(12, 0)", nullable: false),
                    RazonSocial = table.Column<string>(maxLength: 100, nullable: false),
                    MontoTotal = table.Column<decimal>(type: "numeric(18, 2)", nullable: false),
                    CodigoDeControl = table.Column<string>(maxLength: 18, nullable: false),
                    IdEstado = table.Column<int>(nullable: false),
                    CodigoQR = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FCT_Facturas", x => x.IdVenta);
                    table.ForeignKey(
                        name: "FK_FCT_Facturas_INV_Ventas",
                        column: x => x.IdVenta,
                        principalTable: "INV_Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FCT_Facturas_FCT_Dosificaciones",
                        column: x => x.NroAutorizacion,
                        principalTable: "FCT_Dosificaciones",
                        principalColumn: "NroAutorizacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FCT_Reimpresiones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    IdFactura = table.Column<int>(nullable: false),
                    IdUsuario = table.Column<int>(nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: true),
                    Motivo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FCT_Reimpresiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FCT_Reimpresiones_FCT_Facturas",
                        column: x => x.IdFactura,
                        principalTable: "FCT_Facturas",
                        principalColumn: "IdVenta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FCT_AsignacionesSistema_IdActividadEconomica",
                table: "FCT_AsignacionesSistema",
                column: "IdActividadEconomica");

            migrationBuilder.CreateIndex(
                name: "IX_FCT_AsignacionesSistema_IdTipoEmisor",
                table: "FCT_AsignacionesSistema",
                column: "IdTipoEmisor");

            migrationBuilder.CreateIndex(
                name: "IX_FCT_AsignacionesSistema_NroSucursal",
                table: "FCT_AsignacionesSistema",
                column: "NroSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_FCT_AsignacionesSistema_SFC",
                table: "FCT_AsignacionesSistema",
                column: "SFC");

            migrationBuilder.CreateIndex(
                name: "IX_FCT_Dosificaciones_IdAsignacion",
                table: "FCT_Dosificaciones",
                column: "IdAsignacion");

            migrationBuilder.CreateIndex(
                name: "IX_FCT_Facturas_NroAutorizacion",
                table: "FCT_Facturas",
                column: "NroAutorizacion");

            migrationBuilder.CreateIndex(
                name: "IX_FCT_Reimpresiones_IdFactura",
                table: "FCT_Reimpresiones",
                column: "IdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_FCT_Sucursales_IdDireccion",
                table: "FCT_Sucursales",
                column: "IdDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_FCT_Sucursales_IdLogo",
                table: "FCT_Sucursales",
                column: "IdLogo");

            migrationBuilder.CreateIndex(
                name: "IX_GBL_Empresas_IdDireccion",
                table: "GBL_Empresas",
                column: "IdDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_GBL_Empresas_IdLogo",
                table: "GBL_Empresas",
                column: "IdLogo");

            migrationBuilder.CreateIndex(
                name: "IX_GBL_Empresas_IdSitioWeb",
                table: "GBL_Empresas",
                column: "IdSitioWeb");

            migrationBuilder.CreateIndex(
                name: "IX_GBL_Empresas_IdTelefonoPrincipal",
                table: "GBL_Empresas",
                column: "IdTelefonoPrincipal");

            migrationBuilder.CreateIndex(
                name: "IX_GBL_Personas_IdDireccion",
                table: "GBL_Personas",
                column: "IdDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_GBL_Personas_IdTelefonoPrincipal",
                table: "GBL_Personas",
                column: "IdTelefonoPrincipal");

            migrationBuilder.CreateIndex(
                name: "IX_GBL_PropiedadesContacto_IdTipo",
                table: "GBL_PropiedadesContacto",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_INV_Clientes_IdTipoObjeto",
                table: "INV_Clientes",
                column: "IdTipoObjeto");

            migrationBuilder.CreateIndex(
                name: "IX_INV_DetalleCompras_IdCompra",
                table: "INV_DetalleCompras",
                column: "IdCompra");

            migrationBuilder.CreateIndex(
                name: "IX_INV_DetalleCompras_IdProducto",
                table: "INV_DetalleCompras",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_INV_DetalleVentas_IdProducto",
                table: "INV_DetalleVentas",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_INV_DetalleVentas_IdVenta",
                table: "INV_DetalleVentas",
                column: "IdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_INV_Productos_IdCategoria",
                table: "INV_Productos",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_INV_SubProductos_IdSubProducto",
                table: "INV_SubProductos",
                column: "IdSubProducto");

            migrationBuilder.CreateIndex(
                name: "IX_INV_Ventas_IdCliente",
                table: "INV_Ventas",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_INV_Ventas_IdMoneda",
                table: "INV_Ventas",
                column: "IdMoneda");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_ClienteId",
                table: "Ordenes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PAR_Generales_IdTipo",
                table: "PAR_Generales",
                column: "IdTipo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FCT_Empresas");

            migrationBuilder.DropTable(
                name: "FCT_Reimpresiones");

            migrationBuilder.DropTable(
                name: "GBL_Empresas");

            migrationBuilder.DropTable(
                name: "GBL_Personas");

            migrationBuilder.DropTable(
                name: "INV_DetalleCompras");

            migrationBuilder.DropTable(
                name: "INV_DetalleVentas");

            migrationBuilder.DropTable(
                name: "INV_SubProductos");

            migrationBuilder.DropTable(
                name: "Ordenes");

            migrationBuilder.DropTable(
                name: "tblPersonal");

            migrationBuilder.DropTable(
                name: "FCT_Facturas");

            migrationBuilder.DropTable(
                name: "GBL_PropiedadesContacto");

            migrationBuilder.DropTable(
                name: "INV_Compras");

            migrationBuilder.DropTable(
                name: "INV_Productos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "INV_Ventas");

            migrationBuilder.DropTable(
                name: "FCT_Dosificaciones");

            migrationBuilder.DropTable(
                name: "PAR_CategoriasProducto");

            migrationBuilder.DropTable(
                name: "INV_Clientes");

            migrationBuilder.DropTable(
                name: "FCT_AsignacionesSistema");

            migrationBuilder.DropTable(
                name: "PAR_TiposObjeto");

            migrationBuilder.DropTable(
                name: "FCT_ActividadesEconomicas");

            migrationBuilder.DropTable(
                name: "PAR_Generales");

            migrationBuilder.DropTable(
                name: "FCT_Sucursales");

            migrationBuilder.DropTable(
                name: "FCT_SistemasFacturacion");

            migrationBuilder.DropTable(
                name: "GBL_Direcciones");

            migrationBuilder.DropTable(
                name: "GBL_Imagenes");
        }
    }
}
