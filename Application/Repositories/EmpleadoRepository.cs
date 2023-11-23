using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class EmpleadoRepository : GenericRepositoryInt<Empleado>, IEmpleado
    {
        private readonly jardineriaContext _context;

        public EmpleadoRepository(jardineriaContext context) : base(context)
        {
            _context = context;
        }

        // public async Task<IEnumerable<object>> GetJefesdeJefes()
        // {
        //     return await (from _empleado in _context.Empleados
        //     )
        // }
    }
}