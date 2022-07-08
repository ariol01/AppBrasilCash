using AppBrasilCash.Models;
using AppBrasilCash.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrasilCash.Dominio.Models.Factory
{
    public static class AccountFactory
    {
        public static Account Criar(AccountDto accountDto)
        {
            var account = new Account();
            account.Name = accountDto.Name;
            account.TaxId = accountDto.TaxId;
            account.Password = accountDto.Password;
            account.PhoneNumber = accountDto.PhoneNumber;
            account.PostalCode = accountDto.PostalCode;      
            account.Status = accountDto.Status;
            return account;
        }
    }
}
