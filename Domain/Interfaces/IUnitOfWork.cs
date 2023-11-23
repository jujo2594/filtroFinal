using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public ICliente Clientes { get; } // 2611
        public IDetallePedido DetallePedidos { get; } // 2611
        public IEmpleado Empleados { get; } // 2611
        public IGamaProducto GamaProductos { get; } // 2611
        public IOficina Oficinas { get; } // 2611
        public IPago Pagos { get; } // 2611
        public IPedido Pedidos { get; } // 2611
        public IProducto Productos { get; } // 2611
        Task<int> SaveAsync(); // 2611
    }
}