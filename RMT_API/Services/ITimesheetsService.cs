using RMT_API.DTOs;

namespace RMT_API.Services
{
	public interface ITimesheetsService
	{
		Task<IEnumerable<TimesheetDto>> GetAllTimesheetsAsync();
		Task<TimesheetDto> GetTimesheetByIdAsync(int id);
		Task AddTimesheetAsync(TimesheetDto timesheet);
		Task UpdateTimesheetAsync(TimesheetDto timesheet);
		Task DeleteTimesheetAsync(int id);
		Task ChangeStatusTimesheetAsync(TimesheetDto timesheet);
	}
}
