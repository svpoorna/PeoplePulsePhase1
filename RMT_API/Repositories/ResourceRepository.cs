using RMT_API.Models;

namespace RMT_API.Repositories
{
	public class ResourceRepository(IGenericRepository<Resource> _repository) : IResourceRepository
	{
		public async Task ChangeStatusResource(Resource resource)
		{
			var existingResource = _repository.GetByIdAsync(resource.ResourceID, "ResourceID").Result;

			if (existingResource != null)
			{
				existingResource.Status = resource.Status;

				await _repository.UpdateAsync(existingResource);
			}
		}
	}
}
