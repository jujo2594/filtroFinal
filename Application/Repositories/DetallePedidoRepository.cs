using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class DetallePedidoRepository : GenericRepositoryInt<DetallePedido>, IDetallePedido
    {
        private readonly jardineriaContext _context;

        public DetallePedidoRepository(jardineriaContext context) : base(context)
        {
            _context = context;
        }
    }
}