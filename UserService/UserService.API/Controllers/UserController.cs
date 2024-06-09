using Microsoft.AspNetCore.Mvc;

namespace UserService.API.Controllers
{
	[ApiController]
	[Route("api/[Controller]")]
	public class UserController : ControllerBase
	{
		[HttpGet]
		[Route("GetUserList")]
		public async Task<IActionResult> GetUserListAsync()
		{
			await Task.Delay(2000);
			await Task.CompletedTask;
			return Ok("User List OK");
		}

		[HttpGet]
		[Route("GetUserById/{UserId}")]
		public async Task<IActionResult> GetUserByIdAsync([FromRoute] int userId)
		{
			await Task.Delay(2000);
			await Task.CompletedTask;
			return Ok(userId.ToString());
		}
	}
}
