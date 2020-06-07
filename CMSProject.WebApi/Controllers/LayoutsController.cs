using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMSProject.Business.Context;
using CMSProject.Domain.Entities;
using CMSProject.Business.Services.Interfaces;
using CMSProject.Common.Dtos;

namespace CMSProject.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LayoutsController : ControllerBase
    {
		private ILayoutService _layoutService;


		public LayoutsController(ILayoutService layoutService)
		{
			_layoutService = layoutService;
		}

		// GET: api/Layouts
		[HttpGet]
        public IEnumerable<LayoutDto> GetLayouts()
        {
			return _layoutService.GetLayoutList();
			
		}

        // GET: api/Layouts/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetLayout([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var layout = await _context.Layouts.FindAsync(id);

        //    if (layout == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(layout);
        //}

        //// PUT: api/Layouts/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutLayout([FromRoute] int id, [FromBody] Layout layout)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != layout.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(layout).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LayoutExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Layouts
        //[HttpPost]
        //public async Task<IActionResult> PostLayout([FromBody] Layout layout)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Layouts.Add(layout);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetLayout", new { id = layout.Id }, layout);
        //}

        //// DELETE: api/Layouts/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteLayout([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var layout = await _context.Layouts.FindAsync(id);
        //    if (layout == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Layouts.Remove(layout);
        //    await _context.SaveChangesAsync();

        //    return Ok(layout);
        //}

        //private bool LayoutExists(int id)
        //{
        //    return _context.Layouts.Any(e => e.Id == id);
        //}
    }
}