using RMT_API.DTOs;

namespace RMT_API.Services
{
	public interface IRolesService
	{
		Task<IEnumerable<RoleDto>> GetAllRolesAsync();
		Task<RoleDto> GetRoleByIdAsync(int id);
		Task AddRoleAsync(RoleDto role);
		Task UpdateRoleAsync(RoleDto role);
		Task DeleteRoleAsync(int id);
		Task ChangeStatusRoleAsync(RoleDto role);	
	}
}
