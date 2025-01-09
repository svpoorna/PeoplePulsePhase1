using RMT_API.DTOs;

namespace RMT_API.Services
{
	public interface IResourcesService
	{
		Task<IEnumerable<ResourceDto>> GetAllResourcesAsync();
		Task<ResourceDto> GetResourceByIdAsync(int id);
		Task AddResourceAsync(ResourceDto resource);
		Task UpdateResourceAsync(ResourceDto resource);
		Task DeleteResourceAsync(int id);
		Task ChangeStatusResourceAsync(ResourceDto resource);
	}
}
