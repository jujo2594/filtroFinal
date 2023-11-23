
# Project Title

Este es un prpyecto 4 capas en el que se realizaron unas consultas personalizadas para cada
endpoint, se realizo utilizando linq especificamente query expresions, Dtos, Interfaces y respositorios. 

# Consultas

Devuelve un listado con todos los pagos que se realizaron en el año 2008 mediante PayPal. Ordene el resultado de mayor a menor

ENDPOINT:

PagoFechaMetodo

        Task<IEnumerable<Pago>> GetPagosFechaMetodo();

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

        [HttpGet("PagosFechaMetodo")] // 2611
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PagosFechaMetodoDto>>> GetPagosFechaMetodo()
        {
            var results = await _unitOfWork.Pagos.GetPagosFechaMetodo();
            return _mapper.Map<List<PagosFechaMetodoDto>>(results);
        }

