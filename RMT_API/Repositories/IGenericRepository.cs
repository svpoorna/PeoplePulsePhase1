﻿using System.Linq.Expressions;

namespace RMT_API.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
		Task AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(int id);
		Task<T> GetByIdAsync(int id, string idColumnName);
	}
}
