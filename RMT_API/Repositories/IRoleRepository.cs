using RMT_API.Models;

namespace RMT_API.Repositories
{
	public interface IRoleRepository
	{
		Task ChangeStatusRole(Role role);
	}
}
