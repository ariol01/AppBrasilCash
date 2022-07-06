namespace AppBrasilCash.Models.Interface.Service
{
    public interface IAccountService
    {
        Task<Account> Get(int id);
        Task<IList<Account>> GetAll();
        Task Post(Account account);
        Task Put(Account account);
    }
}
