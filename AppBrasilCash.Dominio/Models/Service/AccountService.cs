﻿using AppBrasilCash.Models.Interface.Repository;
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

        public Task<Account> Get(int id)
        {
           return _accountRepository.Get(id);
        }

        public Task<IList<Account>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Post(Account account)
        {
            throw new NotImplementedException();
        }

        public Task Put(Account account)
        {
            throw new NotImplementedException();
        }
    }
}