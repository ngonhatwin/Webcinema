using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Services;

namespace WebCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongController : ControllerBase
    {
        private readonly IPhongServices _services;
        public PhongController(IPhongServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var phong = await _services.GetAll();
            return Ok(phong);
        }
        [HttpGet("get-by-id/{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var phong = await _services.GetById(id);
            if (phong == null)
            {
                return BadRequest("Phòng không tồn tại!");
            }
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Create (PhongModels phong)
        {
            if(phong == null)
            {
                return BadRequest("không có phòng để thêm!");
            }
            await _services.Add(phong);
            return Ok();
        }
        [HttpPost("post_ghe")]
        public async Task<IActionResult> CreateGheByPhong(PhongModels Phong)
        {
            if (Phong == null)
            {
                return BadRequest("không có phòng để thêm!");
            }
            await _services.AddGheByPhong(Phong);
            return Ok();
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> Edit (string id, PhongModels phong)
        {
            if (phong != null)
            {
                await _services.Update(id, phong);
                return Ok();
            }
            return BadRequest("chưa chỉnh sửa được!");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (string id)
        {
            await _services.Delete(id);
            return BadRequest("Đã xóa");
        }
    }
}
