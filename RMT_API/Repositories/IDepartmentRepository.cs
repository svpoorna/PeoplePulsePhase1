using RMT_API.Models;

namespace RMT_API.Repositories
{
	public interface IDepartmentRepository
	{
		Task ChangeStatusDepartment(Department department);
	}
}
