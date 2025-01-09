using RMT_API.Models;

namespace RMT_API.Repositories
{
	public interface ILeaveRepository
	{
		Task ChangeStatusLeave(Leave leave);
	}
}
