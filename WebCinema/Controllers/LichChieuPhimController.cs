﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Services;

namespace WebCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LichChieuPhimController : ControllerBase
    {
        private readonly LichChieuPhimServices services;
        public LichChieuPhimController(LichChieuPhimServices services)
        {
            this.services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var lcp = await services.GetAll();
            return Ok(lcp);
        }

        // Endpoint for retrieving a specific Ctdatve entity by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var lcp = await services.GetById(id);
            return Ok(lcp);
        }

        // Endpoint for adding a new Ctdatve entity
        [HttpPost]
        public async Task<IActionResult> Add(Lichchieuphim Lichchieu)
        {
            if (Lichchieu != null)
            {
                await services.Create(Lichchieu);
            }
            return BadRequest("Đã Thêm");
        }

        // Endpoint for updating an existing Ctdatve entity
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Lichchieuphim Lichchieu)
        {
            if (Lichchieu != null)
            {
                await services.Update(id, Lichchieu);
            }
            return Ok();
        }

        // Endpoint for deleting a specific Ctdatve entity by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await services.Delete(id);
            return BadRequest("Đã xóa lịch chiếu phim");
        }
    }
}
