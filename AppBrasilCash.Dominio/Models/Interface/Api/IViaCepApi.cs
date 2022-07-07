using AppBrasilCash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrasilCash.Dominio.Models.Interface.Api
{
    public interface IViaCepApi
    {
        Task<Address> BsucarCep(string cep);
    }
}
