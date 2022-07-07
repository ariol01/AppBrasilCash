using AppBrasilCash.Models;
using AppBrasilCash.Models.Interface.Repository;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IList<Account>> GetAll()
        {
            return await _context.Accounts.ToListAsync();
        }

        public async Task Post(Account account)
        {
            await _context.AddAsync(account);
            await _context.SaveChangesAsync();
        }
    }
}
