﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCinema.Entities;
using WebCinema.Services;

namespace WebCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaVeController : ControllerBase
    {
        private readonly GiaVeServices services_;
        public GiaVeController(GiaVeServices services)
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
        public async Task<IActionResult> Add(Giave giave)
        {
            if (giave == null)
            {
                return BadRequest();
            }
            await services_.Create(giave);
            return Ok();

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Giave giave)
        {
            if (giave == null)
            {
                return BadRequest();
            }
            await services_.Update(id, giave);
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
