using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Services;

namespace WebCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GheController : ControllerBase
    {
        private readonly GheServices services_;
        public GheController(GheServices services)
        {
            services_ = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await services_.GetAll();
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var theloai = await services_.GetById(id);
            if (theloai == null)
            {
                return NotFound();
            }
            return Ok(theloai);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Ghe ghe)
        {
            if (ghe == null)
            {
                return BadRequest();
            }
            await services_.Create(ghe);
            return Ok();

        }
        [HttpPost("by-models")]
        public async Task<IActionResult> addbymodels(GheModels ghe)
        {
            if (ghe == null)
            {
                return BadRequest();
            }    
            await services_.AddGheByID(ghe);
            return Ok();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Ghe ghe)
        {
            if (ghe == null)
            {
                return BadRequest();
            }
            await services_.Update(id, ghe);
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await services_.Delete(id);
            return Ok("Ctdatve deleted successfully.");
        }
    }
}
