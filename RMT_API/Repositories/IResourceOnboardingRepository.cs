using RMT_API.Models;

namespace RMT_API.Repositories
{
	public interface IResourceOnboardingRepository
	{
		Task ChangeStatusOnboarding(ResourceOnboarding resourceOnboarding);
	}
}
