using RMT_API.Models;

namespace RMT_API.Repositories
{
	public interface ITimesheetRepository
	{
		Task ChangeStatusTimesheet(Timesheet timesheet);
	}
}
