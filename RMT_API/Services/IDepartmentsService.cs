using RMT_API.DTOs;

namespace RMT_API.Services
{
	public interface IDepartmentsService
	{
		Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync();
		Task<DepartmentDto> GetDepartmentByIdAsync(int id);
		Task AddDepartmentAsync(DepartmentDto department);
		Task UpdateDepartmentAsync(DepartmentDto department);
		Task DeleteDepartmentAsync(int id);
		Task ChangeStatusDepartmentAsync(DepartmentDto department);
	}
}
