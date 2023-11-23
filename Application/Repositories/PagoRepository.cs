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
    public class PagoRepository : GenericRepositoryString<Pago>, IPago
    {
        private readonly jardineriaContext _context;

        public PagoRepository(jardineriaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pago>> GetPagosFechaMetodo()
        {
            return await (from _pago in _context.Pagos
            where _pago.FechaPago.Year == 2008 && _pago.FormaPago == "PayPal"
            orderby _pago.Total descending
            select new Pago
            {
                Id = _pago.Id,
                FormaPago = _pago.FormaPago,
                FechaPago = _pago.FechaPago,
                Total = _pago.Total
            }).ToListAsync();
        }

        public async Task<IEnumerable<Pago>> GetTodosMetodosPago()
        {
            return await(from _pago in _context.Pagos
            group _pago by _pago.Id into p 
            select new Pago
            {
                Id = p.Key,
                FormaPago = p.First().FormaPago,
            }).ToListAsync();
        }

    }
}