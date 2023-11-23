using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class PedidoRepository : GenericRepositoryInt<Pedido>, IPedido
    {
        private readonly jardineriaContext _context;

        public PedidoRepository(jardineriaContext context) : base(context)
        {
            _context = context;
        }
    }
}