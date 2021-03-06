﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SIG.FCT.Persistencia.EF.Modelo;

namespace SIG.FCT.Persistencia.EF.Migraciones
{
    [DbContext(typeof(ContextoFCT))]
    partial class ContextoFCTModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Direccion");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.ActividadesEconomicas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Habilitada")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool?>("Principal")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.HasKey("Id");

                    b.ToTable("FCT_ActividadesEconomicas");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.AsignacionesSistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Habilitado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int?>("IdActividadEconomica");

                    b.Property<int?>("IdTipoEmisor");

                    b.Property<int?>("NroSucursal");

                    b.Property<int?>("Sfc")
                        .HasColumnName("SFC");

                    b.HasKey("Id");

                    b.HasIndex("IdActividadEconomica");

                    b.HasIndex("IdTipoEmisor");

                    b.HasIndex("NroSucursal");

                    b.HasIndex("Sfc");

                    b.ToTable("FCT_AsignacionesSistema");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.Dosificaciones", b =>
                {
                    b.Property<decimal>("NroAutorizacion")
                        .HasColumnType("numeric(15, 0)");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FechaLimiteEmision")
                        .HasColumnType("date");

                    b.Property<int>("IdAsignacion");

                    b.Property<int>("IdCaracteristicaEspecial");

                    b.Property<string>("LeyendaAsignada")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<string>("Llave")
                        .HasMaxLength(128);

                    b.Property<string>("NroTramite")
                        .HasMaxLength(12);

                    b.HasKey("NroAutorizacion");

                    b.HasIndex("IdAsignacion");

                    b.ToTable("FCT_Dosificaciones");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.Empresas", b =>
                {
                    b.Property<decimal>("Nit")
                        .HasColumnType("numeric(12, 0)");

                    b.HasKey("Nit");

                    b.ToTable("FCT_Empresas");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.Facturas", b =>
                {
                    b.Property<int>("IdVenta");

                    b.Property<string>("CodigoDeControl")
                        .IsRequired()
                        .HasMaxLength(18);

                    b.Property<byte[]>("CodigoQr")
                        .HasColumnName("CodigoQR")
                        .HasColumnType("image");

                    b.Property<DateTime>("FechaEmision")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("IdEstado");

                    b.Property<decimal>("MontoTotal")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<decimal>("NitCliente")
                        .HasColumnType("numeric(12, 0)");

                    b.Property<decimal>("NroAutorizacion")
                        .HasColumnType("numeric(15, 0)");

                    b.Property<decimal>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(10, 0)")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("IdVenta");

                    b.HasIndex("NroAutorizacion");

                    b.ToTable("FCT_Facturas");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.Reimpresiones", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<int>("IdFactura");

                    b.Property<int?>("IdUsuario");

                    b.Property<string>("Motivo");

                    b.HasKey("Id");

                    b.HasIndex("IdFactura");

                    b.ToTable("FCT_Reimpresiones");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.SistemasFacturacion", b =>
                {
                    b.Property<int>("Sfc")
                        .HasColumnName("SFC");

                    b.Property<string>("Fabricante")
                        .HasMaxLength(250);

                    b.Property<string>("Nombre")
                        .HasMaxLength(50);

                    b.HasKey("Sfc");

                    b.ToTable("FCT_SistemasFacturacion");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.Sucursales", b =>
                {
                    b.Property<int>("Numero");

                    b.Property<string>("Email")
                        .HasMaxLength(10);

                    b.Property<int?>("IdDireccion");

                    b.Property<int?>("IdLogo");

                    b.Property<string>("NombreComercial")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Telefonos")
                        .HasMaxLength(50);

                    b.HasKey("Numero");

                    b.HasIndex("IdDireccion");

                    b.HasIndex("IdLogo");

                    b.ToTable("FCT_Sucursales");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Gbl.Direcciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("Direccion1")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Direccion2")
                        .HasMaxLength(100);

                    b.Property<string>("DireccionDescriptiva")
                        .HasMaxLength(250);

                    b.Property<string>("Lugar")
                        .HasMaxLength(50);

                    b.Property<int?>("PosX")
                        .HasColumnName("Pos_X");

                    b.Property<int?>("PosY")
                        .HasColumnName("Pos_Y");

                    b.HasKey("Id");

                    b.ToTable("GBL_Direcciones");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Gbl.Empresas", b =>
                {
                    b.Property<decimal>("Nit")
                        .HasColumnType("numeric(12, 0)");

                    b.Property<int?>("IdDireccion");

                    b.Property<int?>("IdLogo");

                    b.Property<int?>("IdSitioWeb");

                    b.Property<int?>("IdTelefonoPrincipal");

                    b.Property<int?>("IdTipoSociedad");

                    b.Property<decimal?>("MatriculaComercio")
                        .HasColumnType("numeric(8, 0)");

                    b.Property<string>("RazonSocial")
                        .HasMaxLength(100);

                    b.HasKey("Nit");

                    b.HasIndex("IdDireccion");

                    b.HasIndex("IdLogo");

                    b.HasIndex("IdSitioWeb");

                    b.HasIndex("IdTelefonoPrincipal");

                    b.ToTable("GBL_Empresas");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Gbl.Imagenes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdType");

                    b.Property<byte[]>("Imagen")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("GBL_Imagenes");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Gbl.Personas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FechaNacimiento")
                        .HasMaxLength(10);

                    b.Property<int?>("IdCorreoPrincipal");

                    b.Property<int?>("IdDireccion");

                    b.Property<int?>("IdTelefonoPrincipal");

                    b.Property<int?>("IdTipoDocumento");

                    b.Property<string>("NroDocumento")
                        .HasMaxLength(20);

                    b.Property<string>("PrimerApellido")
                        .HasMaxLength(10);

                    b.Property<string>("PrimerNombre")
                        .HasMaxLength(120);

                    b.Property<string>("SegundoApellido")
                        .HasMaxLength(10);

                    b.Property<string>("SegundoNombre")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("IdDireccion");

                    b.HasIndex("IdTelefonoPrincipal");

                    b.ToTable("GBL_Personas");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Gbl.PropiedadesContacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdTipo");

                    b.Property<string>("Valor")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdTipo");

                    b.ToTable("GBL_PropiedadesContacto");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("IdObjeto")
                        .HasColumnType("numeric(12, 0)");

                    b.Property<int?>("IdTipoObjeto");

                    b.Property<decimal>("Nit")
                        .HasColumnType("numeric(12, 0)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("IdTipoObjeto");

                    b.ToTable("INV_Clientes");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.Compras", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("Fecha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("IdMoneda")
                        .HasMaxLength(10);

                    b.Property<string>("IdProveedor")
                        .HasMaxLength(10);

                    b.Property<int>("IdUsuario");

                    b.Property<double>("TipoCambio")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.HasKey("Id");

                    b.ToTable("INV_Compras");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.DetalleCompras", b =>
                {
                    b.Property<int>("Id");

                    b.Property<short>("Cantidad");

                    b.Property<decimal>("CostoUnidad")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<int>("IdCompra");

                    b.Property<int>("IdProducto");

                    b.Property<decimal?>("Total")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("numeric(24, 2)")
                        .HasComputedColumnSql("([Cantidad]*[CostoUnidad])");

                    b.HasKey("Id");

                    b.HasIndex("IdCompra");

                    b.HasIndex("IdProducto");

                    b.ToTable("INV_DetalleCompras");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.DetalleVentas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Cantidad");

                    b.Property<string>("Comentarios")
                        .HasMaxLength(250);

                    b.Property<int>("IdProducto");

                    b.Property<int>("IdVenta");

                    b.Property<decimal?>("MontoTotal")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("numeric(35, 2)")
                        .HasComputedColumnSql("(([Cantidad]*[PrecioUnitario])*((1)-[PctDescuento]/(100)))");

                    b.Property<short>("PctDescuento");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("numeric(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("IdProducto");

                    b.HasIndex("IdVenta");

                    b.ToTable("INV_DetalleVentas");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasMaxLength(10);

                    b.Property<string>("Descripcion");

                    b.Property<bool?>("EsParaVenta")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("IdCategoria");

                    b.Property<int>("IdTipoUnidad");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<decimal>("Precio")
                        .HasColumnType("numeric(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.ToTable("INV_Productos");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.SubProductos", b =>
                {
                    b.Property<int>("IdProducto");

                    b.Property<int>("IdSubProducto");

                    b.HasKey("IdProducto", "IdSubProducto");

                    b.HasIndex("IdSubProducto");

                    b.ToTable("INV_SubProductos");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.Ventas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("IdCliente");

                    b.Property<int>("IdMoneda");

                    b.Property<int>("IdVendedor");

                    b.Property<double>("TipoCambio")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdMoneda");

                    b.ToTable("INV_Ventas");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId");

                    b.Property<DateTime?>("FechaEntrega");

                    b.Property<DateTime?>("FechaOrden")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Par.CategoriasProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("PAR_CategoriasProducto");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Par.Generales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasMaxLength(10);

                    b.Property<string>("Descripcion");

                    b.Property<bool?>("Habilitado")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int?>("IdTipo");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Orden")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.HasKey("Id");

                    b.HasIndex("IdTipo");

                    b.ToTable("PAR_Generales");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Par.TiposObjeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("TablaAsociada")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("PAR_TiposObjeto");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Tbl.Personal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<double?>("PayRate");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("tblPersonal");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.AsignacionesSistema", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Fct.ActividadesEconomicas", "IdActividadEconomicaNavigation")
                        .WithMany("AsignacionesSistema")
                        .HasForeignKey("IdActividadEconomica")
                        .HasConstraintName("FK_FCT_AsignacionesSistema_FCT_ActividadesEconomicas");

                    b.HasOne("SIG.FCT.CORE.Entidades.Par.Generales", "IdTipoEmisorNavigation")
                        .WithMany("FctAsignacionesSistema")
                        .HasForeignKey("IdTipoEmisor")
                        .HasConstraintName("FK_FCT_AsignacionesSistema_FCT_Parametros");

                    b.HasOne("SIG.FCT.CORE.Entidades.Fct.Sucursales", "NroSucursalNavigation")
                        .WithMany("FctAsignacionesSistema")
                        .HasForeignKey("NroSucursal")
                        .HasConstraintName("FK_FCT_AsignacionesSistema_FCT_Sucursales");

                    b.HasOne("SIG.FCT.CORE.Entidades.Fct.SistemasFacturacion", "SfcNavigation")
                        .WithMany("FctAsignacionesSistema")
                        .HasForeignKey("Sfc")
                        .HasConstraintName("FK_FCT_AsignacionesSistema_FCT_SistemasFacturacion");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.Dosificaciones", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Fct.AsignacionesSistema", "IdAsignacionNavigation")
                        .WithMany("FctDosificaciones")
                        .HasForeignKey("IdAsignacion")
                        .HasConstraintName("FK_FCT_Dosificaciones_FCT_AsignacionesSistema");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.Facturas", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Inv.Ventas", "IdVentaNavigation")
                        .WithOne("FctFacturas")
                        .HasForeignKey("SIG.FCT.CORE.Entidades.Fct.Facturas", "IdVenta")
                        .HasConstraintName("FK_FCT_Facturas_INV_Ventas");

                    b.HasOne("SIG.FCT.CORE.Entidades.Fct.Dosificaciones", "NroAutorizacionNavigation")
                        .WithMany("FctFacturas")
                        .HasForeignKey("NroAutorizacion")
                        .HasConstraintName("FK_FCT_Facturas_FCT_Dosificaciones");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.Reimpresiones", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Fct.Facturas", "IdFacturaNavigation")
                        .WithMany("FctReimpresiones")
                        .HasForeignKey("IdFactura")
                        .HasConstraintName("FK_FCT_Reimpresiones_FCT_Facturas");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Fct.Sucursales", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Gbl.Direcciones", "IdDireccionNavigation")
                        .WithMany("FctSucursales")
                        .HasForeignKey("IdDireccion")
                        .HasConstraintName("FK_FCT_Sucursales_GBL_Direcciones");

                    b.HasOne("SIG.FCT.CORE.Entidades.Gbl.Imagenes", "IdLogoNavigation")
                        .WithMany("FctSucursales")
                        .HasForeignKey("IdLogo")
                        .HasConstraintName("FK_FCT_Sucursales_GBL_Imagenes");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Gbl.Empresas", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Gbl.Direcciones", "IdDireccionNavigation")
                        .WithMany("GblEmpresas")
                        .HasForeignKey("IdDireccion")
                        .HasConstraintName("FK_GBL_Empresa_GBL_Direcciones");

                    b.HasOne("SIG.FCT.CORE.Entidades.Gbl.Imagenes", "IdLogoNavigation")
                        .WithMany("GblEmpresas")
                        .HasForeignKey("IdLogo")
                        .HasConstraintName("FK_GBL_Empresa_GBL_Imagenes");

                    b.HasOne("SIG.FCT.CORE.Entidades.Gbl.PropiedadesContacto", "IdSitioWebNavigation")
                        .WithMany("EmpresasIdSitioWebNavigation")
                        .HasForeignKey("IdSitioWeb")
                        .HasConstraintName("FK_GBL_Empresa_GBL_DatosContacto");

                    b.HasOne("SIG.FCT.CORE.Entidades.Gbl.PropiedadesContacto", "IdTelefonoPrincipalNavigation")
                        .WithMany("EmpresasIdTelefonoPrincipalNavigation")
                        .HasForeignKey("IdTelefonoPrincipal")
                        .HasConstraintName("FK_GBL_Empresa_GBL_DatosContacto1");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Gbl.Personas", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Gbl.Direcciones", "IdDireccionNavigation")
                        .WithMany("GblPersonas")
                        .HasForeignKey("IdDireccion")
                        .HasConstraintName("FK_GBL_Personas_GBL_Direcciones");

                    b.HasOne("SIG.FCT.CORE.Entidades.Gbl.PropiedadesContacto", "IdTelefonoPrincipalNavigation")
                        .WithMany("Personas")
                        .HasForeignKey("IdTelefonoPrincipal")
                        .HasConstraintName("FK_GBL_Personas_GBL_DatosContacto");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Gbl.PropiedadesContacto", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Par.Generales", "IdTipoNavigation")
                        .WithMany("GblPropiedadesContacto")
                        .HasForeignKey("IdTipo")
                        .HasConstraintName("FK_GBL_DatosContacto_PAR_GENERALES");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.Clientes", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Par.TiposObjeto", "IdTipoObjetoNavigation")
                        .WithMany("InvClientes")
                        .HasForeignKey("IdTipoObjeto")
                        .HasConstraintName("FK_INV_Clientes_PAR_TiposObjeto");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.DetalleCompras", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Inv.Compras", "IdCompraNavigation")
                        .WithMany("InvDetalleCompras")
                        .HasForeignKey("IdCompra")
                        .HasConstraintName("FK_INV_DetalleCompras_INV_Compras")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SIG.FCT.CORE.Entidades.Inv.Productos", "IdProductoNavigation")
                        .WithMany("InvDetalleCompras")
                        .HasForeignKey("IdProducto")
                        .HasConstraintName("FK_INV_DetalleCompras_INV_Productos");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.DetalleVentas", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Inv.Productos", "IdProductoNavigation")
                        .WithMany("InvDetalleVentas")
                        .HasForeignKey("IdProducto")
                        .HasConstraintName("FK_INV_DetalleVentas_INV_Productos");

                    b.HasOne("SIG.FCT.CORE.Entidades.Inv.Ventas", "IdVentaNavigation")
                        .WithMany("InvDetalleVentas")
                        .HasForeignKey("IdVenta")
                        .HasConstraintName("FK_INV_DetalleVentas_INV_Ventas")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.Productos", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Par.CategoriasProducto", "IdCategoriaNavigation")
                        .WithMany("InvProductos")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("FK_INV_Productos_PAR_CategoriasProducto");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.SubProductos", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Inv.Productos", "IdProductoNavigation")
                        .WithMany("InvSubProductosIdProductoNavigation")
                        .HasForeignKey("IdProducto")
                        .HasConstraintName("FK_INV_SubProductos_INV_Productos");

                    b.HasOne("SIG.FCT.CORE.Entidades.Inv.Productos", "IdSubProductoNavigation")
                        .WithMany("InvSubProductosIdSubProductoNavigation")
                        .HasForeignKey("IdSubProducto")
                        .HasConstraintName("FK_INV_SubProductos_INV_Productos1");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Inv.Ventas", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Inv.Clientes", "IdClienteNavigation")
                        .WithMany("InvVentas")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FK_INV_Ventas_INV_Clientes");

                    b.HasOne("SIG.FCT.CORE.Entidades.Par.Generales", "IdMonedaNavigation")
                        .WithMany("InvVentas")
                        .HasForeignKey("IdMoneda")
                        .HasConstraintName("FK_INV_Ventas_PAR_Generales1");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Orden", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Cliente", "Cliente")
                        .WithMany("Ordenes")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("SIG.FCT.CORE.Entidades.Par.Generales", b =>
                {
                    b.HasOne("SIG.FCT.CORE.Entidades.Par.Generales", "IdTipoNavigation")
                        .WithMany("InverseIdTipoNavigation")
                        .HasForeignKey("IdTipo")
                        .HasConstraintName("FK_FCT_Parametros_FCT_Parametros");
                });
#pragma warning restore 612, 618
        }
    }
}
