using Microsoft.AspNetCore.Mvc;
using WebCinema.Models;
using WebCinema.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using WebCinema.Entities;

namespace WebCinema.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CtdatveController : ControllerBase
    {
        private readonly ICtdatveService _ctdatveService;

        public CtdatveController(ICtdatveService ctdatveService)
        {
            _ctdatveService = ctdatveService;
        }

        // Endpoint for retrieving all Ctdatve entities
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ctdatves = await _ctdatveService.GetAll();
            return Ok(ctdatves);
        }

        // Endpoint for retrieving a specific Ctdatve entity by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var ctdatve = await _ctdatveService.GetById(id);
            if (ctdatve == null)
            {
                return NotFound();
            }
            return Ok(ctdatve);
        }

        // Endpoint for adding a new Ctdatve entity
        [HttpPost]
        public async Task<IActionResult> Add(CtdatveModels ctdatveModel)
        {
            if(ctdatveModel == null)
            {
                return BadRequest();
            }
            await _ctdatveService.Add(ctdatveModel);
            return Ok();
            
        }

        // Endpoint for updating an existing Ctdatve entity
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id,  CtdatveModels ctdatveModel)
        {
            if (ctdatveModel == null)
            {
                return BadRequest();
            }
            await _ctdatveService.Update(id, ctdatveModel);
            return Ok();
        }

        // Endpoint for deleting a specific Ctdatve entity by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _ctdatveService.Delete(id);
            return Ok("Ctdatve deleted successfully.");
        }
    }
}