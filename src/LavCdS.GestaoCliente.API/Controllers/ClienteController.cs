using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LavCdS.GestaoCliente.Domain.Interface;
using Newtonsoft.Json;

namespace LavCdS.GestaoCliente.API.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        IBuscaCliente buscarCliente;
        public ClienteController(IBuscaCliente buscarCliente)
        {
            this.buscarCliente = buscarCliente;
        }

        // GET: api/Cliente/5
        [HttpGet("{id_cliente}", Name = "Get")]
        public async Task<string> getClientePorId(int id_cliente)
        {
            ICliente cliente = await buscarCliente.getClientePorId(id_cliente);
            return JsonConvert.SerializeObject(cliente);
        }

        // GET: api/Cliente/fulano
        [HttpGet("/nome/{nome_cliente}", Name = "Get")]
        public async Task<string> getClientePorNome(string nome_cliente)
        {
            List<ICliente> cliente = await buscarCliente.getClientePorNome(nome_cliente);
            return JsonConvert.SerializeObject(cliente);
        }

        // POST: api/Cliente
        [HttpPost]
        public void Post([FromBody] ICliente value)
        {
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ICliente value)
        {
        }

    }
}
