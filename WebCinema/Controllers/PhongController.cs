﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Services;

[Route("api/[controller]")]
[ApiController]
public class PhongController : ControllerBase
{
    private readonly PhongServices _services;

    public PhongController(PhongServices services)
    {
        _services = services ?? throw new ArgumentNullException(nameof(services));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var phongs = await _services.GetAll();
        return Ok(phongs);
    }

    [HttpGet("get-by-id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var phong = await _services.GetById(id);
        if (phong == null)
        {
            return BadRequest("Phòng không tồn tại!");
        }
        return Ok(phong);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Phong phong)
    {
        if (phong == null)
        {
            return BadRequest("Không có phòng để thêm!");
        }
        await _services.Create(phong);
        return CreatedAtAction(nameof(GetById), new { id = phong.MaPhong }, phong);
    }
    [HttpPost("add-ghe")]
    public async Task<IActionResult> CreateGheByPhong(PhongModels phong)
    {
        if (phong == null)
        {
            return BadRequest();
        }    
        await _services.CustomCreate(phong);
        return Ok(phong);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Edit(string id, Phong phong)
    {
        if (phong != null)
        {
            await _services.Update(id, phong);
            return Ok();
        }
        return BadRequest("Chưa chỉnh sửa được!");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _services.Delete(id);
        return NoContent();
    }
}
