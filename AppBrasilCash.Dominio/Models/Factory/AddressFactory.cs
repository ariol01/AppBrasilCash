using AppBrasilCash.Dominio.Models.Dtos;
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
        public static Address Criar(AddressDto addressDto)
        {
            var address = new Address();
            if (addressDto is not null)
            {
                address.Street = addressDto.Bairro;
                address.City = addressDto.Localidade;
                address.District = addressDto.Bairro;
                address.State = addressDto.Uf;
            }            
            return address;
        }
    }
}
