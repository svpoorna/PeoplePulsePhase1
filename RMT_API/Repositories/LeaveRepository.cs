using RMT_API.Models;

namespace RMT_API.Repositories
{
	public class LeaveRepository(IGenericRepository<Leave> repository) : ILeaveRepository
	{
		private readonly IGenericRepository<Leave> _repository = repository;

		public async Task ChangeStatusLeave(Leave leave)
		{
			var existingLeave = await _repository.GetByIdAsync(leave.LeaveID, "LeaveID");

			if (existingLeave != null)
			{
				existingLeave.Status = leave.Status;

				await _repository.UpdateAsync(existingLeave);
			}
		}
	}

}
