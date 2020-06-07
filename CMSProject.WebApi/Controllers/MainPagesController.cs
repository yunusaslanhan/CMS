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
using System.Text;

namespace CMSProject.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainPagesController : ControllerBase
    {
		private IMainPageServices _mainPageServices;

        public MainPagesController(IMainPageServices mainPageServices)
        {
			_mainPageServices = mainPageServices;
        }

		// GET: api/MainPages
		[HttpGet]
		public IEnumerable<MainPageDto> GetMainPages()
		{
			return _mainPageServices.GetMainPageList();
		}


		[HttpGet]
		public string GetGenerateMenuUi()
		{
			return _mainPageServices.GenerateMenuUi();
		}

		//[HttpGet]
		//public void AddChildItem(MainPageDto childItem, StringBuilder strBuilder)
		//{

		//     _mainPageServices.AddChildItem(childItem, strBuilder);

		//}

		//// GET: api/MainPages/5
		//[HttpGet("{id}")]
		//public async Task<IActionResult> GetMainPage([FromRoute] int id)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    var mainPage = await _context.MainPages.FindAsync(id);

		//    if (mainPage == null)
		//    {
		//        return NotFound();
		//    }

		//    return Ok(mainPage);
		//}

		//// PUT: api/MainPages/5
		//[HttpPut("{id}")]
		//public async Task<IActionResult> PutMainPage([FromRoute] int id, [FromBody] MainPage mainPage)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    if (id != mainPage.Id)
		//    {
		//        return BadRequest();
		//    }

		//    _context.Entry(mainPage).State = EntityState.Modified;

		//    try
		//    {
		//        await _context.SaveChangesAsync();
		//    }
		//    catch (DbUpdateConcurrencyException)
		//    {
		//        if (!MainPageExists(id))
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

		//// POST: api/MainPages
		//[HttpPost]
		//public async Task<IActionResult> PostMainPage([FromBody] MainPage mainPage)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    _context.MainPages.Add(mainPage);
		//    await _context.SaveChangesAsync();

		//    return CreatedAtAction("GetMainPage", new { id = mainPage.Id }, mainPage);
		//}

		//// DELETE: api/MainPages/5
		//[HttpDelete("{id}")]
		//public async Task<IActionResult> DeleteMainPage([FromRoute] int id)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    var mainPage = await _context.MainPages.FindAsync(id);
		//    if (mainPage == null)
		//    {
		//        return NotFound();
		//    }

		//    _context.MainPages.Remove(mainPage);
		//    await _context.SaveChangesAsync();

		//    return Ok(mainPage);
		//}

		//private bool MainPageExists(int id)
		//{
		//    return _context.MainPages.Any(e => e.Id == id);
		//}
	}
}