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
        public async Task<Account> Get(string desc)
        {
            return await _context.Accounts.FirstOrDefaultAsync(x=>x.Name == desc || x.TaxId.Contains(desc) || x.TaxId.Equals(desc) || x.CreatedAt.Equals(desc));
        }

        public async Task<IList<Account>> GetAll()
        {
            return await _context.Accounts.ToListAsync();
        }

        public async Task Post(Account account)
        {
            await _context.Accounts.AddAsync(account);
            await _context.SaveChangesAsync();
        }
    }
}
