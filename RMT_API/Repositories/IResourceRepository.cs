using RMT_API.DTOs;
using RMT_API.Models;

namespace RMT_API.Repositories
{
	public interface IResourceRepository
	{
		Task ChangeStatusResource(Resource resource);
		Task<IEnumerable<Resource>> GetResourcesByProjectId(int projectId);
	}
}
