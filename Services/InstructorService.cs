using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Http.HttpResults;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Text;


namespace WebApplication1.Services
{
	public class InstructorService : IInstructor
	{
		private readonly HttpClient _httpClient;
		private readonly IConfiguration _config;
		private readonly Credentials _credentials;

		public InstructorService(HttpClient httpClient, IConfiguration configuration, Credentials credentials)
		{
			_httpClient = httpClient;
			_config = configuration;
			_credentials = credentials;
		}

		public async Task<string> AddInstructorAsync(InstructorData instructor)
		{
			try
			{
				var client = _credentials.ObjNav();
				await client.InsertInstructorDataAsync(
					instructor.Instructor_Name,
					instructor.Instructor_ID,
					instructor.Instructor_Phone_Number,
					instructor.Instructor_Email,
					instructor.Instructor_Rate
				);
				return "Instructor added successfully";
			}
			catch (Exception ex)
			{
				return $"Error adding instructor: {ex.Message}";
			}
		}

		public async Task<InstructorData> GetInstructorByIdAsync(string instructorId)
		{
			try
			{
				var client = _credentials.ObjNav();
				var result = await client.GetInstructorByIdAsync(instructorId); // Replace with actual method name
				return new InstructorData
				{
					//Instructor_Name = result.InstructorName,
					//Instructor_ID = result.InstructorId,
					//Instructor_Email = result.InstructorEmail,
					//Instructor_Phone_Number = result.InstructorPhoneNumber,
					//Instructor_Rate = result.InstructorRate
				};
			}
			catch (Exception ex)
			{
				// Handle not found or other errors as needed
				throw new Exception($"Error fetching instructor: {ex.Message}");
			}
		}

		public async Task<List<InstructorData>> GetAllInstructorsAsync()
		{
			try
			{
				var client = _credentials.ObjNav();
				// Adjust `GetAllInstructorsResult` and its collection name based on generated types
				var results = await client.GetAllInstructorsAsync();

				// Initialize the list
				var instructors = new List<InstructorData>();

				return instructors;

				/*
				// Ensure `results` is not null and iterate correctly based on your generated structure
				if (results != null)
				{
					foreach (var instructor in results)
					{
						instructors.Add(new InstructorData
						{
							Instructor_Name = instructor.InstructorName, // Confirm property names
							Instructor_ID = instructor.InstructorId,
							Instructor_Email = instructor.InstructorEmail,
							Instructor_Phone_Number = instructor.InstructorPhoneNumber,
							Instructor_Rate = instructor.InstructorRate
						});
					}
				} */

			}
			catch (Exception ex)
			{
				throw new Exception($"Error fetching instructors: {ex.Message}");
			}
		}

		public async Task<string> UpdateInstructorAsync(InstructorData instructor)
		{
			try
			{
				var client = _credentials.ObjNav();
				await client.UpdateInstructorAsync(
					instructor.Instructor_ID,
					instructor.Instructor_Name,
					instructor.Instructor_Phone_Number,
					instructor.Instructor_Email,
					instructor.Instructor_Rate
				);
				return "Instructor updated successfully";
			}
			catch (Exception ex)
			{
				return $"Error updating instructor: {ex.Message}";
			}
		}

		public async Task<string> DeleteInstructorAsync(string instructorId)
		{
			try
			{
				var client = _credentials.ObjNav();
				await client.DeleteInstructorAsync(instructorId); // Replace with actual method name
				return "Instructor deleted successfully";
			}
			catch (Exception ex)
			{
				return $"Error deleting instructor: {ex.Message}";
			}
		}

	}

	// Your existing InstructorData class
	public class InstructorData
	{
		public string Instructor_Name { get; set; }
		public string Instructor_ID { get; set; }
		public string Instructor_Email { get; set; }
		public string Instructor_Phone_Number { get; set; }
		public int Instructor_Rate { get; set; }
	}
}