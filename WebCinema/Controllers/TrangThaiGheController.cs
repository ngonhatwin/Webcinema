﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Services;

namespace WebCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrangThaiGheController : ControllerBase
    {
        private readonly TrangThaiGheServices _services;
        public TrangThaiGheController(TrangThaiGheServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await _services.GetAll();
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var theloai = await _services.GetById(id);
            if (theloai == null)
            {
                return NotFound();
            }
            return Ok(theloai);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Trangthaighe trangthai)
        {
            if (trangthai == null)
            {
                return BadRequest();
            }
            await _services.Create(trangthai);
            return Ok();

        }

        [HttpPost("by-models")]
        public async Task<IActionResult> Addbymodels(TrangThaiGheModels trangthaiGhe)
        {
            if (trangthaiGhe == null)
            {
                return BadRequest();
            }
            await _services.addTTGbyModels(trangthaiGhe);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Trangthaighe trangthai)
        {
            if (trangthai == null)
            {
                return BadRequest();
            }
            await _services.Update(id, trangthai);
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _services.Delete(id);
            return Ok("Ctdatve deleted successfully.");
        }
    }
}
