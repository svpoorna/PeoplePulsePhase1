using RMT_API.Models;

namespace RMT_API.Repositories
{
	public interface IClientRepository
	{
		Task ChangeStatusClient(Client client);
	}

}
