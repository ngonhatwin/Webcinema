﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Services;

namespace WebCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TdKhachHangController : ControllerBase
    {
        private readonly TdKhachHangServices _services;
        public TdKhachHangController(TdKhachHangServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var diem = await _services.GetAll();
            return Ok(diem);
        }
        [HttpGet("get-by-id/{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var diem = await _services.GetById(id);
            if (diem == null)
            {
                return BadRequest();
            }
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Tdkhachhang diem)
        {
            if (diem == null)
            {
                return BadRequest("không có phòng để thêm!");
            }
            await _services.Create(diem);
            return Ok();
        }

        [HttpPost("by-models")]
        public async Task<IActionResult> CreatebyModels(TdKhachHangModels diem)
        {
            if (diem == null)
            {
                return BadRequest();
            }    
            await _services.Addttkh(diem);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(string id, Tdkhachhang diem)
        {
            if (diem != null)
            {
                await _services.Update(id, diem);
                return Ok();
            }
            return BadRequest("chưa chỉnh sửa được!");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _services.Delete(id);
            return BadRequest("Đã xóa");
        }
    }
}
