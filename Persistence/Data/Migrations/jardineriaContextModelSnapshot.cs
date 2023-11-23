﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(jardineriaContext))]
    partial class jardineriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ApellidoContacto")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("apellido_contacto");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ciudad");

                    b.Property<string>("CodigoPostal")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("codigo_postal");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("fax");

                    b.Property<int?>("IdEmpleadoRepresentanteVentasFk")
                        .HasColumnType("int")
                        .HasColumnName("idEmpleadoRepresentanteVentasFk");

                    b.Property<decimal?>("LimiteCredito")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("limite_credito");

                    b.Property<string>("LineaDireccion1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("linea_direccion1");

                    b.Property<string>("LineaDireccion2")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("linea_direccion2");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_cliente");

                    b.Property<string>("NombreContacto")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nombre_contacto");

                    b.Property<string>("Pais")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("pais");

                    b.Property<string>("Region")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("region");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("telefono");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdEmpleadoRepresentanteVentasFk" }, "idEmpleadoRepresentanteVentasFk");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DetallePedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<int>("IdPedidoFk")
                        .HasColumnType("int")
                        .HasColumnName("idPedidoFk");

                    b.Property<string>("IdProductoFk")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("idProductoFk");

                    b.Property<short>("NumeroLinea")
                        .HasColumnType("smallint")
                        .HasColumnName("numero_linea");

                    b.Property<decimal>("PrecioUnidad")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("precio_unidad");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPedidoFk" }, "idPedidoFk");

                    b.HasIndex(new[] { "IdProductoFk" }, "idProductoFk");

                    b.ToTable("detalle_pedido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellido1");

                    b.Property<string>("Apellido2")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellido2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("extension");

                    b.Property<int?>("IdEmpleadoJefeFk")
                        .HasColumnType("int")
                        .HasColumnName("idEmpleadoJefeFk");

                    b.Property<string>("IdOficinaFk")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("idOficinaFk");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<string>("Puesto")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("puesto");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdEmpleadoJefeFk" }, "idEmpleadoJefeFk");

                    b.HasIndex(new[] { "IdOficinaFk" }, "idOficinaFk");

                    b.ToTable("empleado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.GamaProducto", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("id");

                    b.Property<string>("DescripcionHtml")
                        .HasColumnType("text")
                        .HasColumnName("descripcion_html");

                    b.Property<string>("DescripcionTexto")
                        .HasColumnType("text")
                        .HasColumnName("descripcion_texto");

                    b.Property<string>("Imagen")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("imagen");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("gama_producto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Oficina", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("id");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("ciudad");

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("codigo_postal");

                    b.Property<string>("LineaDireccion1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("linea_direccion1");

                    b.Property<string>("LineaDireccion2")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("linea_direccion2");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("pais");

                    b.Property<string>("Region")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("region");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("telefono");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("oficina", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("id");

                    b.Property<DateOnly>("FechaPago")
                        .HasColumnType("date")
                        .HasColumnName("fecha_pago");

                    b.Property<string>("FormaPago")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("forma_pago");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int")
                        .HasColumnName("idClienteFk");

                    b.Property<decimal>("Total")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("total");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdClienteFk" }, "idClienteFkk");

                    b.ToTable("pago", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Comentarios")
                        .HasColumnType("text")
                        .HasColumnName("comentarios");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("estado");

                    b.Property<DateOnly?>("FechaEntrega")
                        .HasColumnType("date")
                        .HasColumnName("fecha_entrega");

                    b.Property<DateOnly>("FechaEsperada")
                        .HasColumnType("date")
                        .HasColumnName("fecha_esperada");

                    b.Property<DateOnly>("FechaPedido")
                        .HasColumnType("date")
                        .HasColumnName("fecha_pedido");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int")
                        .HasColumnName("idClienteFk");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdClienteFk" }, "idClienteFk");

                    b.ToTable("pedido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("id");

                    b.Property<short>("CantidadEnStock")
                        .HasColumnType("smallint")
                        .HasColumnName("cantidad_en_stock");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text")
                        .HasColumnName("descripcion");

                    b.Property<string>("Dimensiones")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("dimensiones");

                    b.Property<string>("IdGamaFk")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("idGamaFk");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("nombre");

                    b.Property<decimal?>("PrecioProveedor")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("precio_proveedor");

                    b.Property<decimal>("PrecioVenta")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("precio_venta");

                    b.Property<string>("Proveedor")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("proveedor");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdGamaFk" }, "idGamaFk");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.HasOne("Domain.Entities.Empleado", "IdEmpleadoRepresentanteVentasFkNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("IdEmpleadoRepresentanteVentasFk")
                        .HasConstraintName("idEmpleadoRepresentanteVentasFk");

                    b.Navigation("IdEmpleadoRepresentanteVentasFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.DetallePedido", b =>
                {
                    b.HasOne("Domain.Entities.Pedido", "IdPedidoFkNavigation")
                        .WithMany("DetallePedidos")
                        .HasForeignKey("IdPedidoFk")
                        .IsRequired()
                        .HasConstraintName("idPedidoFk");

                    b.HasOne("Domain.Entities.Producto", "IdProductoFkNavigation")
                        .WithMany("DetallePedidos")
                        .HasForeignKey("IdProductoFk")
                        .IsRequired()
                        .HasConstraintName("idProductoFk");

                    b.Navigation("IdPedidoFkNavigation");

                    b.Navigation("IdProductoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.HasOne("Domain.Entities.Empleado", "IdEmpleadoJefeFkNavigation")
                        .WithMany("InverseIdEmpleadoJefeFkNavigation")
                        .HasForeignKey("IdEmpleadoJefeFk")
                        .HasConstraintName("idEmpleadoJefeFk");

                    b.HasOne("Domain.Entities.Oficina", "IdOficinaFkNavigation")
                        .WithMany("Empleados")
                        .HasForeignKey("IdOficinaFk")
                        .IsRequired()
                        .HasConstraintName("idOficinaFk");

                    b.Navigation("IdEmpleadoJefeFkNavigation");

                    b.Navigation("IdOficinaFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "IdClienteFkNavigation")
                        .WithMany("Pagos")
                        .HasForeignKey("IdClienteFk")
                        .IsRequired()
                        .HasConstraintName("idClienteFkk");

                    b.Navigation("IdClienteFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "IdClienteFkNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdClienteFk")
                        .IsRequired()
                        .HasConstraintName("idClienteFk");

                    b.Navigation("IdClienteFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.HasOne("Domain.Entities.GamaProducto", "IdGamaFkNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdGamaFk")
                        .IsRequired()
                        .HasConstraintName("idGamaFk");

                    b.Navigation("IdGamaFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Pagos");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("InverseIdEmpleadoJefeFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.GamaProducto", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.Oficina", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Navigation("DetallePedidos");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Navigation("DetallePedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
