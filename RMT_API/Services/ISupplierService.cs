using RMT_API.DTOs;

namespace RMT_API.Services
{
	public interface ISupplierService
	{
		Task AddSupplierAsync(SupplierDto supplier);

		Task DeleteSupplierAsync(int id);

		Task<IEnumerable<SupplierDto>> GetAllSuppliersAsync();

		Task<SupplierDto> GetSupplierByIdAsync(int id);

		Task UpdateSupplierAsync(SupplierDto supplier);

		Task ChangeStatusSupplierAsync(SupplierDto supplier);
	}
}
