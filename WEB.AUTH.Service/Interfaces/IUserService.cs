using WEB.AUTH.Domain;
using WEB.AUTH.Domain.DTO;

namespace WEB.AUTH.Service.Interfaces;

public interface IUserService<T>
{
    Task<T> Login(LoginDTO loginDto);
    Task<List<T>> GetAll();
    Task<T> GetById(Guid id);
    Task<T> Create(T entity);
    Task<bool> Delete(Guid id);
    
}