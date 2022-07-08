using AppBrasilCash.Models;

namespace AppBrasilCash.Application.Interface.AppService
{
    public interface IAccountAppService
    {
        Task<Account> Get(string desc);
        Task<IList<Account>> GetAll();
        Task Post(Account account);
    }
}
