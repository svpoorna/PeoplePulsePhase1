using RMT_API.Models;

namespace RMT_API.Repositories
{
	public class TimesheetRepository(IGenericRepository<Timesheet> repository) : ITimesheetRepository
	{
		private readonly IGenericRepository<Timesheet> _repository = repository;

		public async Task ChangeStatusTimesheet(Timesheet timesheet)
		{
			var existingTimesheet = await _repository.GetByIdAsync(timesheet.TimesheetID, "TimesheetID");

			if (existingTimesheet != null)
			{
				existingTimesheet.Status = timesheet.Status;

				await _repository.UpdateAsync(existingTimesheet);
			}
		}
	}

}
