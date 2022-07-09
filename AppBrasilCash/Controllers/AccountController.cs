using AppBrasilCash.Application.Interface.AppService;
using AppBrasilCash.Application.Service;
using AppBrasilCash.Dominio.Models.Factory;
using AppBrasilCash.Dominio.Models.Helpers;
using AppBrasilCash.Dominio.Models.Interface.Api;
using AppBrasilCash.Models.Dtos;
using AppBrasilCash.Models.Validation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppBrasilCash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountAppService _accountAppService;
        private readonly IViaCepApi _viaCepApi;
        public AccountController(IAccountAppService accountAppService, IViaCepApi viaCepApi)
        {
            _accountAppService = accountAppService;
            _viaCepApi = viaCepApi;
        }
        // GET: api/<AccountController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var resultado = await _accountAppService.GetAll();

            if (resultado.Any())
            {
                return Ok(resultado);
            }
            return BadRequest("Erro ao buscar todas as contas do cliente.");
        }

        // GET api/<AccountController>/5
        [HttpGet("{desc}")]
        public async Task<IActionResult> Get(string desc)
        {
            var resultado = await _accountAppService.Get(desc);
            if (resultado != null)
            {
                return Ok(resultado);
            }
            return BadRequest("Cliente não encontrado.");

        }

        // POST api/<AccountController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AccountDto accountDto)
        {
            var result = new AccountValidation().Validate(accountDto);
            
            var addressDto = _viaCepApi.BuscarCep(accountDto.PostalCode);
            
            var account = AccountFactory.Criar(accountDto);
            
            account.Address = AddressFactory.Criar(addressDto);
            
            account.Status = addressDto is null ? account.Status: "Approved";
            var EhCpfOuCpnjValido = CpfHelper.Validar(account.TaxId) || CpnjHelper.Validar(account.TaxId);
            
            if (result.IsValid && EhCpfOuCpnjValido)
            {
                await _accountAppService.Post(account);
                return Ok(account);
            }
            return BadRequest("Erro ao tentar gravar a conta do cliente.");
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
