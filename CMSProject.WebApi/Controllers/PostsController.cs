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
    public class PostsController : ControllerBase
    {
		private IPostServices _postServices;


        public PostsController(IPostServices postServices)
        {
			_postServices = postServices;
        }

        // GET: api/Posts
        [HttpGet]
        public IEnumerable<PostDto> GetPosts()
        {
			return _postServices.GetPostList();
        }

		[HttpGet]
		public IEnumerable<SliderDto> GetSliders()
		{
			return _postServices.GetSliderList();
		}


		// GET: api/Posts/5
		[HttpGet("{id}")]
		public IEnumerable<PostDetailDto> GetPostDetail(int id)
		{
			return _postServices.GetPostDetailList(id);
		}

		[HttpGet("{id}")]
		public IEnumerable<PostDto> GetMainPagePost(int id)
		{
			return _postServices.GetMainPagePostList(id);

		}



		//// PUT: api/Posts/5
		//[HttpPut("{id}")]
		//public async Task<IActionResult> PutPost([FromRoute] int id, [FromBody] Post post)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    if (id != post.PostId)
		//    {
		//        return BadRequest();
		//    }

		//    _context.Entry(post).State = EntityState.Modified;

		//    try
		//    {
		//        await _context.SaveChangesAsync();
		//    }
		//    catch (DbUpdateConcurrencyException)
		//    {
		//        if (!PostExists(id))
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

		//// POST: api/Posts
		//[HttpPost]
		//public async Task<IActionResult> PostPost([FromBody] Post post)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    _context.Posts.Add(post);
		//    await _context.SaveChangesAsync();

		//    return CreatedAtAction("GetPost", new { id = post.PostId }, post);
		//}

		//// DELETE: api/Posts/5
		//[HttpDelete("{id}")]
		//public async Task<IActionResult> DeletePost([FromRoute] int id)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    var post = await _context.Posts.FindAsync(id);
		//    if (post == null)
		//    {
		//        return NotFound();
		//    }

		//    _context.Posts.Remove(post);
		//    await _context.SaveChangesAsync();

		//    return Ok(post);
		//}

		//private bool PostExists(int id)
		//{
		//    return _context.Posts.Any(e => e.PostId == id);
		//}
	}
}