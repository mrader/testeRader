using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Totvs.Dtos;

namespace Totvs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionController : ControllerBase
    {

        private readonly ItransaccionService _transaccionService;

        public TransaccionController(ItransaccionService transaccionService)
        {
            this._transaccionService = transaccionService;
        }

        [HttpPost]
        public ActionResult Post([FromBody] PostTransaccionDto dto)
        {
            try
            {
                var tran = _transaccionService.GetChange(dto.idCliente, dto.idPuntoVenta, dto.importeAPagar, dto.importePagado);

                return Ok(tran);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }

}
