using RMT_API.Models;

namespace RMT_API.Repositories
{
	public interface IProjectRepository
	{
		Task ChangeStatusProject(Project project);
	}
}
