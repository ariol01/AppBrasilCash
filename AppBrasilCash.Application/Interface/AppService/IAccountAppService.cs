using AppBrasilCash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrasilCash.Application.Interface.AppService
{
    public interface IAccountAppService
    {
        Task<Account> Get(int id);
        Task<IList<Account>> GetAll();
        Task Post(Account account);
    }
}
