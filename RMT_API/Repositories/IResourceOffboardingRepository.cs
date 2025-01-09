using RMT_API.Models;

namespace RMT_API.Repositories
{
	public interface IResourceOffboardingRepository
	{
		Task ChangeStatusOffboarding(ResourceOffboarding resourceOffboarding);
	}
}
