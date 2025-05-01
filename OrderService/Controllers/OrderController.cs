using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.Models;

namespace OrderService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrderController : ControllerBase
	{
		private readonly OrderDbContext _context;

		public OrderController(OrderDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll() => Ok(await _context.Orders.ToListAsync());

		[HttpPost]
		public async Task<IActionResult> Create(Order order)
		{
			_context.Orders.Add(order);
			await _context.SaveChangesAsync();
			return Ok(order);
		}
	}
}
