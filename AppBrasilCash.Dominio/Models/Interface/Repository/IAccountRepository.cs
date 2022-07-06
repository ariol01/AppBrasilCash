namespace AppBrasilCash.Models.Interface.Repository
{
    public interface IAccountRepository
    {
        Task<Account> Get(int id);
        Task<IList<Account>> GetAll();
        Task Post(Account account);
    }
}
