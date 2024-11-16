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
using NAVWS;


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
				var result = await client.GetInstructorByIdAsync(instructorId);

				// Debug logging
				Console.WriteLine($"Raw JSON returned: {result.return_value}");

				if (!string.IsNullOrEmpty(result.return_value))
				{
					var settings = new JsonSerializerSettings
					{
						Error = (sender, args) =>
						{
							Console.WriteLine($"JSON Error: {args.ErrorContext.Error.Message}");
							args.ErrorContext.Handled = true;
						},
						NullValueHandling = NullValueHandling.Ignore,
						MissingMemberHandling = MissingMemberHandling.Ignore
					};

					try
					{
						var instructor = JsonConvert.DeserializeObject<InstructorData>(result.return_value, settings);

						// Validate the deserialized object
						if (instructor != null)
						{
							Console.WriteLine($"Deserialized Instructor: ID={instructor.Instructor_ID}, Name={instructor.Instructor_Name}");
							return instructor;
						}
					}
					catch (JsonReaderException jex)
					{
						Console.WriteLine($"JSON parsing error: {jex.Message}");
						throw new Exception($"Invalid JSON format returned from server: {jex.Message}");
					}
				}

				throw new Exception($"Instructor with ID {instructorId} not found");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Exception in GetInstructorByIdAsync: {ex.Message}");
				throw new Exception($"Error fetching instructor: {ex.Message}");
			}
		}


		public async Task<List<InstructorData>> GetAllInstructorsAsync()
		{
			try
			{
				var client = _credentials.ObjNav();
				var result = await client.GetAllInstructorsAsync();

				// Debug logging
				Console.WriteLine($"Raw JSON returned: {result.return_value}");

				if (!string.IsNullOrEmpty(result.return_value))
				{
					var settings = new JsonSerializerSettings
					{
						Error = (sender, args) =>
						{
							Console.WriteLine($"JSON Error: {args.ErrorContext.Error.Message}");
							args.ErrorContext.Handled = true;
						},
						NullValueHandling = NullValueHandling.Ignore,
						MissingMemberHandling = MissingMemberHandling.Ignore
					};

					try
					{
						var instructors = JsonConvert.DeserializeObject<List<InstructorData>>(result.return_value, settings);

						// Debug logging
						if (instructors != null)
						{
							foreach (var instructor in instructors)
							{
								Console.WriteLine($"Deserialized Instructor: ID={instructor.Instructor_ID}, Name={instructor.Instructor_Name}");
							}
						}

						return instructors ?? new List<InstructorData>();
					}
					catch (JsonReaderException jex)
					{
						Console.WriteLine($"JSON parsing error: {jex.Message}");
						throw new Exception($"Invalid JSON format returned from server: {jex.Message}");
					}
				}

				return new List<InstructorData>();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Exception in GetAllInstructorsAsync: {ex.Message}");
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
				await client.DeleteInstructorAsync(instructorId);
				return "Instructor deleted successfully";
			}
			catch (Exception ex)
			{
				return $"Error deleting instructor: {ex.Message}";
			}
		}

	}

	// YInstructorData class
	public class InstructorData
	{
		[JsonProperty("instructorName")]
		public string Instructor_Name { get; set; }

		[JsonProperty("instructorId")]
		public string Instructor_ID { get; set; }

		[JsonProperty("instructorEmail")]
		public string Instructor_Email { get; set; }

		[JsonProperty("instructorPhoneNumber")]
		public string Instructor_Phone_Number { get; set; }

		[JsonProperty("instructorRate")]
		public decimal Instructor_Rate { get; set; }
	}
}