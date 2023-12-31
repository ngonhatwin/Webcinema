﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Services;

namespace WebCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TtDatVeController : ControllerBase
    {
        private readonly TtDatVeServices _services;
        public TtDatVeController(TtDatVeServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ctdatves = await _services.GetAll();
            return Ok(ctdatves);
        }

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

        [HttpPost]
        public async Task<IActionResult> Add(Ttdatve ttdv)
        {
            if (ttdv == null)
            {
                return BadRequest();
            }
            await _services.Create(ttdv);
            return Ok();

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Ttdatve ttdv)
        {
            if (ttdv == null)
            {
                return BadRequest();
            }
            await _services.Update(id, ttdv);
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
