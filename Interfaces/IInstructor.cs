using WebApplication1.Services;

namespace WebApplication1.Interfaces
{
	public interface IInstructor
	{
		Task<string> AddInstructorAsync(InstructorData instructor);
		Task<InstructorData> GetInstructorByIdAsync(string instructorId);
		Task<List<InstructorData>> GetAllInstructorsAsync();
		Task<string> UpdateInstructorAsync(InstructorData instructor);
		Task<string> DeleteInstructorAsync(string instructorId);
	}
}
