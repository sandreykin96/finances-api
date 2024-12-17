using Finances.Bll.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Finances.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class FinancesController : ControllerBase
    {
        private readonly IFinancesServices _relationsGraphService;

        public FinancesController(IFinancesServices relationsGraphService)
        {
            _relationsGraphService = relationsGraphService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<Dal.Entities.Finances>>> GetChildrenAsync(int userId, string period)
        {
            var children = await _relationsGraphService.GetFinancesAsync(userId, period);

            return Ok(children);
        }
    }
}
