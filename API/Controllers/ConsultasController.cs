using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ConsultasController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ConsultasController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("PagosFechaMetodo")] // 2611
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PagosFechaMetodoDto>>> GetPagosFechaMetodo()
        {
            var results = await _unitOfWork.Pagos.GetPagosFechaMetodo();
            return _mapper.Map<List<PagosFechaMetodoDto>>(results);
        }

        [HttpGet("MetodosPago")] // 2611
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MetodoPagoDto>>> GetTodosMetodosPago()
        {
            var results = await _unitOfWork.Pagos.GetTodosMetodosPago();
            return _mapper.Map<List<MetodoPagoDto>>(results);
        }

        [HttpGet("ClientesConCompras")] // 2611
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<object>>> GetInfoClientePagos()
        {
            var results = await _unitOfWork.Clientes.GetInfoClientePagos();
            return _mapper.Map<List<object>>(results);
        }

        [HttpGet("ProductoSinPedido")] // 2611
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<object>>> GetProductoSinPedido()
        {
            var results = await _unitOfWork.Productos.GetProductoSinPedido();
            return _mapper.Map<List<object>>(results);
        }
    }
}