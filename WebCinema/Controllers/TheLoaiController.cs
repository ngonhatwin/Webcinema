using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Services;

namespace WebCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheLoaiController : ControllerBase
    {
        private TheLoaiServices services_;
        public TheLoaiController(TheLoaiServices services)
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
        public async Task<IActionResult> Add(Theloai theloai)
        {
            if (theloai == null)
            {
                return BadRequest();
            }
            await services_.Create(theloai);
            return Ok();

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Theloai theloai)
        {
            if (theloai == null)
            {
                return BadRequest();
            }
            await services_.Update(id, theloai);
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
