using RMT_API.Models;

namespace RMT_API.Repositories
{
	public interface IResourceLifeCycleRepository
	{
		Task ChangeStatusResourceLifeCycle(ResourceLifecycle resourceLifeCycle);
	}
}
