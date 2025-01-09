using RMT_API.Models;

namespace RMT_API.Repositories
{
	public class ResourceLifeCycleRepository(IGenericRepository<ResourceLifecycle> repository) : IResourceLifeCycleRepository
	{
		private readonly IGenericRepository<ResourceLifecycle> _repository = repository;

		public async Task ChangeStatusResourceLifeCycle(ResourceLifecycle resourceLifeCycle)
		{
			var existingLifeCycle = await _repository.GetByIdAsync(resourceLifeCycle.LifecycleID, "LifecycleID");

			if (existingLifeCycle != null)
			{
				existingLifeCycle.Status = resourceLifeCycle.Status;

				await _repository.UpdateAsync(existingLifeCycle);
			}
		}
	}

}
