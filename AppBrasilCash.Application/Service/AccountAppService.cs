using AppBrasilCash.Application.Interface.AppService;
using AppBrasilCash.Models;
using AppBrasilCash.Models.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrasilCash.Application.Service
{
    public class AccountAppService : IAccountAppService
    {
        private readonly IAccountService _accountService;
        public AccountAppService(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public async Task<Account> Get(int id)
        {
          return await _accountService.Get(id);
        }

        public Task<IList<Account>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Post(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
