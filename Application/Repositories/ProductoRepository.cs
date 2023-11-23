using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repositories
{
    public class ProductoRepository : GenericRepositoryString<Producto>, IProducto
    {
        private readonly jardineriaContext _context;

        public ProductoRepository(jardineriaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<object>> GetProductoSinPedido()
        {
            return await(from _producto in _context.Productos
            join _detallePedido in _context.DetallePedidos on _producto.Id equals _detallePedido.IdProductoFk
            join _gamaProducto in _context.GamaProductos on _producto.IdGamaFk equals _gamaProducto.Id
            where _producto.Id! == _detallePedido.IdProductoFk
            select new
            {
                Nombre = _producto.Nombre,
                Descripcion = _gamaProducto.DescripcionTexto,
                Imagen = _gamaProducto.Imagen
            }).ToListAsync();
        }
    }
}