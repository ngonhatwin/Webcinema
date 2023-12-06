using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Services;

namespace WebCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NguoiDungController : ControllerBase
    {
        private readonly NguoiDungServices services_;
        public NguoiDungController(NguoiDungServices services_)
        {
            this.services_ = services_;
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
        public async Task<IActionResult> Add(Nguoidung nguoidung)
        {
            if (nguoidung == null)
            {
                return BadRequest();
            }
            await services_.Create(nguoidung);
            return Ok();

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Nguoidung nguoidung)
        {
            if (nguoidung == null)
            {
                return BadRequest();
            }
            await services_.Update(id, nguoidung);
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
