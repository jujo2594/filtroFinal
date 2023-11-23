using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly jardineriaContext _context;
        private ICliente _cliente; // 2611
        private IDetallePedido _detallePedido; // 2611
        private IEmpleado _empleado; // 2611
        private IGamaProducto _gamaProducto; // 2611
        private IOficina _oficina; // 2611
        private IPago _pago; // 2611
        private IPedido _pedido; // 2611
        private IProducto _producto; // 2611
        public UnitOfWork(jardineriaContext context) // 2611
        {
        _context = context;
        }

        public ICliente Clientes // 2611
        {
            get
            {
                if (_cliente == null)
                {
                    _cliente = new ClienteRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _cliente;
            }
        }

        public IDetallePedido DetallePedidos // 2611
        {
            get
            {
                if (_detallePedido == null)
                {
                    _detallePedido = new DetallePedidoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _detallePedido;
            }
        }

        public IEmpleado Empleados // 2611
        {
            get
            {
                if (_empleado == null)
                {
                    _empleado = new EmpleadoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _empleado;
            }
        }

        public IGamaProducto GamaProductos // 2611
        {
            get
            {
                if (_gamaProducto == null)
                {
                    _gamaProducto = new GamaProductoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _gamaProducto;
            }
        }

        public IOficina Oficinas // 2611
        {
            get
            {
                if (_oficina == null)
                {
                    _oficina = new OficinaRepository(_context);
                }
                return _oficina;
            }
        }

        public IPago Pagos // 2611
        {
            get
            {
                if (_pago == null)
                {
                    _pago = new PagoRepository(_context);
                }
                return _pago;
            }
        }

        public IPedido Pedidos // 2611
        {
            get
            {
                if (_pedido == null)
                {
                    _pedido = new PedidoRepository(_context);
                }
                return _pedido;
            }
        }

        public IProducto Productos // 2611
        {
            get
            {
                if (_producto == null)
                {
                    _producto = new ProductoRepository(_context);
                }
                return _producto;
            }
        }

        public Task<int> SaveAsync() // 2611
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}