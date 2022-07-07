using AppBrasilCash.Dominio.Models.Dtos;
using AppBrasilCash.Dominio.Models.Interface.Api;
using AppBrasilCash.Models;
using Newtonsoft.Json;
using RestSharp;

namespace AppBrasilCash.Dominio.Models.Service.Api
{
    public class ViaCepApi : IViaCepApi
    {
        public AddressDto BuscarCep(string cep)
        {
            var url = string.Format("http://viacep.com.br/ws/{0}/json", cep);
            RestClient restClient = new RestClient();
            RestRequest restRequest = new RestRequest(url, Method.Get);

            var response = restClient.Execute(restRequest);

            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                return null;
            }
            else
            {
                var retorno = JsonConvert.DeserializeObject<AddressDto>(response.Content);
                return retorno;
            }
        }
    }
}
