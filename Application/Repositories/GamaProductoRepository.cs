using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class GamaProductoRepository : GenericRepositoryString<GamaProducto>, IGamaProducto
    {
        private readonly jardineriaContext _context;

        public GamaProductoRepository(jardineriaContext context) : base(context)
        {
            _context = context;
        }
    }
}