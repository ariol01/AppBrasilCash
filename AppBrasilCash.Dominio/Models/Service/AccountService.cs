using AppBrasilCash.Models.Interface.Repository;
using AppBrasilCash.Models.Interface.Service;

namespace AppBrasilCash.Models.Service
{
    public class AccountService : IAccountService
    {

        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Task<Account> Get(string desc)
        {
           return _accountRepository.Get(desc);
        }

        public async Task<IList<Account>> GetAll()
        {
            return await _accountRepository.GetAll();   
        }

        public async Task Post(Account account)
        {
            await _accountRepository.Post(account);
        }

        public Task Put(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
