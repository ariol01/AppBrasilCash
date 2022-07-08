namespace AppBrasilCash.Models.Interface.Service
{
    public interface IAccountService
    {
        Task<Account> Get(string desc);
        Task<IList<Account>> GetAll();
        Task Post(Account account);
        Task Put(Account account);
    }
}
