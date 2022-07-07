using AppBrasilCash.Dominio.Models.Interface.Api;
using AppBrasilCash.Models;
using AppBrasilCash.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrasilCash.Dominio.Models.Factory
{
    public static class AddressFactory
    {
        public static Address Criar(AccountDto accountDto)
        {
            var address = new Address();

            if (accountDto.PostalCode != null)
            {
                var teste = IViaCepApi.BuscarCep(accountDto.PostalCode);
                address.Street = teste.Street;
                address.City = teste.City;
                address.District = teste.District;
                address.State = teste.State;
            }
            return address;
        }
    }
}
