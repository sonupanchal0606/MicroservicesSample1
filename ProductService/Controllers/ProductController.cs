using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductService.Data;
using ProductService.Models;

namespace ProductService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly ProductDbContext _context;

		public ProductController(ProductDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll() => Ok(await _context.Products.ToListAsync());

		[HttpPost]
		public async Task<IActionResult> Create(Product product)
		{
			product.Id = 0; // to make sure key is auto incremented
			_context.Products.Add(product);
			await _context.SaveChangesAsync();
			return Ok(product);
		}
	}
}
