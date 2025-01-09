using RMT_API.Models;

namespace RMT_API.Repositories
{
	public interface ISupplierRepository
	{
		Task ChangeStatusSupplier(Supplier supplier);
	}
}
