using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProducto : IGenericRepositoryString<Producto>
    {
        Task<IEnumerable<object>> GetProductoSinPedido();
    }
}