using RMT_API.Models;

namespace RMT_API.Repositories
{
	public class UserRepository(IGenericRepository<Users> repository) : IUserRepository
	{
		private readonly IGenericRepository<Users> _repository = repository;

		public async Task ChangeStatusUser(Users user)
		{
			var existingUser = await _repository.GetByIdAsync(user.UserID, "UserID");

			if (existingUser != null)
			{
				existingUser.IsActive = user.IsActive;

				await _repository.UpdateAsync(existingUser);
			}
		}
	}

}
