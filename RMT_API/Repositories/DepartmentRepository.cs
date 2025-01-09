using RMT_API.Models;

namespace RMT_API.Repositories
{
	public class DepartmentRepository(IGenericRepository<Department> repository) : IDepartmentRepository
	{
		private readonly IGenericRepository<Department> _repository = repository;

		public async Task ChangeStatusDepartment(Department department)
		{
			var existingDepartment = await _repository.GetByIdAsync(department.DepartmentID, "DepartmentID");

			if (existingDepartment != null)
			{
				existingDepartment.Status = department.Status;

				await _repository.UpdateAsync(existingDepartment);
			}
		}
	}

}
