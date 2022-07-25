using System.Linq.Expressions;
using Devon4Net.Application.WebAPI.Implementation.Business.DishManagement.Dto;
using Devon4Net.Application.WebAPI.Implementation.Domain.Entities;

namespace Devon4Net.Application.WebAPI.Implementation.Business.DishManagement.Service
{
    /// <summary>
    /// TodoService interface
    /// </summary>
    public interface IDishService
    {
        Task<IEnumerable<DishDto>> GetDish(Expression<Func<Dish, bool>> predicate = null);
    }
}