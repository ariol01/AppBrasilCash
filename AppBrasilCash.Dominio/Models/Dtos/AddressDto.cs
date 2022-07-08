using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrasilCash.Dominio.Models.Dtos
{
    public class AddressDto
    {
        public string Bairro { get; set; }
        public string Uf { get; set; }
        public string Localidade { get; set; }
        public string District { get; set; }
    }
}
