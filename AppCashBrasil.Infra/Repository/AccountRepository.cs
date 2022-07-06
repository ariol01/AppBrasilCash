using AppBrasilCash.Models;
using AppBrasilCash.Models.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCashBrasil.Infra.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;
        public AccountRepository(DataContext context)
        {
            _context = context;
        }
        public Task<Account> Get(int id)
        {
            return null;
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
