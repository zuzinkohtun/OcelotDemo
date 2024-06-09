using Microsoft.AspNetCore.Mvc;

namespace ProductService.API.Controllers
{
	[Route("api/[Controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		[HttpGet]
		[Route("GetProductList")]
		public async Task<IActionResult> GetProductListAsync()
		{
			await Task.Delay(2000);
			await Task.CompletedTask;
			return Ok("Product List OK");
		}

		[HttpGet]
		[Route("GetProductById/{productId}")]
		public async Task<IActionResult> GetProductByIdAsync([FromRoute]int productId)
		{
			await Task.Delay(2000);
			await Task.CompletedTask;
			return Ok(productId.ToString());
		}
	}
}
