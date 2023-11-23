using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using SQLitePCL;

namespace Application.Repositories
{
    public class ClienteRepository : GenericRepositoryInt<Cliente>, ICliente
    {
        private readonly jardineriaContext _context;

        public ClienteRepository(jardineriaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<object>> GetInfoClientePagos()
        {
            return await (from _cliente in _context.Clientes
            join _empleado in _context.Empleados on _cliente.IdEmpleadoRepresentanteVentasFk equals _empleado.Id
            join _pago in _context.Pagos on _cliente.Id equals _pago.IdClienteFk
            join _oficina in _context.Oficinas on _empleado.IdOficinaFk equals _oficina.Id
            group _cliente by new {_cliente.NombreCliente, _empleado.Nombre, _oficina.Ciudad} into p
            select new
            {
                NombreCliente = p.Key.NombreCliente,
                NombreEmpleado = p.Key.Nombre,
                CiudadOficina = p.Key.Ciudad
            }).ToListAsync();
        }
    }
}