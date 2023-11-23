using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPago : IGenericRepositoryString<Pago>
    {
        Task<IEnumerable<Pago>> GetPagosFechaMetodo();
        Task<IEnumerable<Pago>> GetTodosMetodosPago();
    }
}