using RMT_API.Models;

namespace RMT_API.Repositories
{
	public class ResourceOnboardingRepository(IGenericRepository<ResourceOnboarding> repository) : IResourceOnboardingRepository
	{
		private readonly IGenericRepository<ResourceOnboarding> _repository = repository;

		public async Task ChangeStatusOnboarding(ResourceOnboarding resourceOnboarding)
		{
			var existingOnboarding = await _repository.GetByIdAsync(resourceOnboarding.OnboardingID, "OnboardingID");

			if (existingOnboarding != null)
			{
				existingOnboarding.Status = resourceOnboarding.Status;

				await _repository.UpdateAsync(existingOnboarding);
			}
		}
	}

}
