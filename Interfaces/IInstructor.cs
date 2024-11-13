using WebApplication1.Services;

namespace WebApplication1.Interfaces
{
	public interface IInstructor
	{
		/*
		Task<dynamic> PostData(InstructorData instructor);

		// New method for getting all instructors
		Task<IEnumerable<InstructorData>> GetAllInstructors();

		// New method for getting an instructor by ID
		Task<InstructorData?> GetInstructorById(int id);

		// New method for deleting an instructor by ID
		Task<bool> DeleteInstructor(int id);

		// New method for updating an instructor
		Task<bool> UpdateInstructor(int id, InstructorData instructor);
		*/
		Task<string> AddInstructorAsync(InstructorData instructor);
		Task<InstructorData> GetInstructorByIdAsync(string instructorId);
		Task<List<InstructorData>> GetAllInstructorsAsync();
		Task<string> UpdateInstructorAsync(InstructorData instructor);
		Task<string> DeleteInstructorAsync(string instructorId);
	}
}
