using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCinema.Models;
using WebCinema.Services;

namespace WebCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TtDatVeController : ControllerBase
    {
        private readonly ITtDatVeServices _services;
        public TtDatVeController(ITtDatVeServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ctdatves = await _services.GetAll();
            return Ok(ctdatves);
        }

        // Endpoint for retrieving a specific Ctdatve entity by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var ctdatve = await _services.GetById(id);
            if (ctdatve == null)
            {
                return NotFound();
            }
            return Ok(ctdatve);
        }

        // Endpoint for adding a new Ttdatve entity
        [HttpPost]
        public async Task<IActionResult> Add(TtdatveModels ttdv)
        {
            if (ttdv == null)
            {
                return BadRequest();
            }
            await _services.Add(ttdv);
            return Ok();

        }

        // Endpoint for updating an existing Ctdatve entity
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, TtdatveModels ttdv)
        {
            if (ttdv == null)
            {
                return BadRequest();
            }
            await _services.Update(id, ttdv);
            return Ok();
        }

        // Endpoint for deleting a specific Ctdatve entity by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await  _services.Delete(id);
            return Ok("Ctdatve deleted successfully.");
        }

    }
}
