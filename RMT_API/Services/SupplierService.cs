using AutoMapper;
using RMT_API.DTOs;
using RMT_API.Models;
using RMT_API.Repositories;

namespace RMT_API.Services
{
	public class SupplierService(IGenericRepository<Supplier> _repository, ISupplierRepository supplierRepository, IMapper _mapper) : ISupplierService
	{
		public async Task AddSupplierAsync(SupplierDto supplier)
		{
			await _repository.AddAsync(_mapper.Map<Supplier>(supplier));
		}

		public async Task DeleteSupplierAsync(int id)
		{
			await _repository.DeleteAsync(id);
		}

		public async Task<IEnumerable<SupplierDto>> GetAllSuppliersAsync()
		{
			var response = await _repository.GetAllAsync();
			return _mapper.Map<IEnumerable<SupplierDto>>(response);
		}

		public async Task<SupplierDto> GetSupplierByIdAsync(int id)
		{
			var response = await _repository.GetByIdAsync(id);
			return _mapper.Map<SupplierDto>(response);
		}

		public async Task UpdateSupplierAsync(SupplierDto supplier)
		{
			await _repository.UpdateAsync(_mapper.Map<Supplier>(supplier));
		}

		public async Task ChangeStatusSupplierAsync(SupplierDto supplier)
		{
			await supplierRepository.ChangeStatusSupplier(_mapper.Map<Supplier>(supplier));
		}
	}
}
