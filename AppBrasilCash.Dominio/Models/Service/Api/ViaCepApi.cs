using AppBrasilCash.Dominio.Models.Interface.Api;
using AppBrasilCash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrasilCash.Dominio.Models.Service.Api
{
    public class ViaCepApi : IViaCepApi
    {
        public Task<Address> BsucarCep(string cep)
        {
            throw new NotImplementedException();
        }
    }
}
