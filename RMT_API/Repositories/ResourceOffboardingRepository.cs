using RMT_API.Models;

namespace RMT_API.Repositories
{
	public class ResourceOffboardingRepository(IGenericRepository<ResourceOffboarding> repository) : IResourceOffboardingRepository
	{
		private readonly IGenericRepository<ResourceOffboarding> _repository = repository;

		public async Task ChangeStatusOffboarding(ResourceOffboarding resourceOffboarding)
		{
			var existingOffboarding = await _repository.GetByIdAsync(resourceOffboarding.OffboardingID, "OffboardingID");

			if (existingOffboarding != null)
			{
				existingOffboarding.Status = resourceOffboarding.Status;

				await _repository.UpdateAsync(existingOffboarding);
			}
		}
	}

}
