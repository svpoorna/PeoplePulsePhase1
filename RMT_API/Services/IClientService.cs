using RMT_API.DTOs;

namespace RMT_API.Services
{
	public interface IClientService
	{
		Task<IEnumerable<ClientDto>> GetAllClientsAsync();
		Task<ClientDto> GetClientByIdAsync(int id);
		Task AddClientAsync(ClientDto client);
		Task UpdateClientAsync(ClientDto client);
		Task DeleteClientAsync(int id);
		Task ChangeStatusClientAsync(ClientDto client);
	}
}
