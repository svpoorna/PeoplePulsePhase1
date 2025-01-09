using RMT_API.DTOs;

namespace RMT_API.Services
{
	public interface IResourceDeploymentsService
	{
		Task<IEnumerable<ResourceDeploymentDto>> GetAllResourceDeploymentsAsync();
		Task<ResourceDeploymentDto> GetResourceDeploymentByIdAsync(int id);
		Task AddResourceDeploymentAsync(ResourceDeploymentDto resourceDeployment);
		Task UpdateResourceDeploymentAsync(ResourceDeploymentDto resourceDeployment);
		Task DeleteResourceDeploymentAsync(int id);
		Task ChangeStatusResourceDeploymentAsync(ResourceDeploymentDto deployment);
	}
}
