using WebApplication1.Interfaces;
using WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Core.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InstructorController : ControllerBase
	{
		private readonly InstructorService _instructorService;
		private readonly IInstructor _instructor;

		public InstructorController(InstructorService instructorService, IInstructor instructor)
		{
			_instructorService = instructorService;
			_instructor = instructor;
		}

		[HttpPost("add")]
		public async Task<IActionResult> AddInstructor([FromBody] InstructorData instructor)
		{
			try
			{
				var result = await _instructorService.AddInstructorAsync(instructor);
				return Ok(result);
			}
			catch (ArgumentException ex)
			{
				return BadRequest(ex.Message);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Internal server error: {ex.Message}");
			}
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetInstructorById(string id)
		{
			try
			{
				var instructor = await _instructorService.GetInstructorByIdAsync(id);
				return instructor != null ? Ok(instructor) : NotFound("Instructor not found.");
			}
			catch (ArgumentException ex)
			{
				return BadRequest(ex.Message);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Internal server error: {ex.Message}");
			}
		}

		[HttpGet]
		public async Task<IActionResult> GetAllInstructors()
		{
			try
			{
				var instructors = await _instructorService.GetAllInstructorsAsync();
				return Ok(instructors);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Internal server error: {ex.Message}");
			}
		}

		[HttpPut]
		public async Task<IActionResult> UpdateInstructor([FromBody] InstructorData instructor)
		{
			try
			{
				var result = await _instructorService.UpdateInstructorAsync(instructor);
				return Ok(result);
			}
			catch (ArgumentException ex)
			{
				return BadRequest(ex.Message);
			}
			catch (KeyNotFoundException ex)
			{
				return NotFound(ex.Message);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Internal server error: {ex.Message}");
			}
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteInstructor(string id)
		{
			try
			{
				var result = await _instructorService.DeleteInstructorAsync(id);
				return Ok(result);
			}
			catch (KeyNotFoundException ex)
			{
				return NotFound(ex.Message);
			}
			catch (ArgumentException ex)
			{
				return BadRequest(ex.Message);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Internal server error: {ex.Message}");
			}
		}
	}
}
