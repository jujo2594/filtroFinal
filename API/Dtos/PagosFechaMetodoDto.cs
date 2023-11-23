using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PagosFechaMetodoDto
    {
        public string Id { get; set; }
        public DateOnly FechaPago { get; set; }
        public string FormaPago { get; set; }
        public int MyProperty { get; set; }
        public decimal Total { get; set; }
    }
}