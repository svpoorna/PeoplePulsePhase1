using RMT_API.Models;

namespace RMT_API.Repositories
{
	public class RoleRepository(IGenericRepository<Role> repository) : IRoleRepository
	{
		private readonly IGenericRepository<Role> _repository = repository;

		public async Task ChangeStatusRole(Role role)
		{
			var existingRole = await _repository.GetByIdAsync(role.RoleID, "RoleID");

			if (existingRole != null)
			{
				existingRole.Status = role.Status;

				await _repository.UpdateAsync(existingRole);
			}
		}
	}

}
