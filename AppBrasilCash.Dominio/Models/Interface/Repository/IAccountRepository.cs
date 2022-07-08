namespace AppBrasilCash.Models.Interface.Repository
{
    public interface IAccountRepository
    {
        Task<Account> Get(string desc);
        Task<IList<Account>> GetAll();
        Task Post(Account account);
    }
}
