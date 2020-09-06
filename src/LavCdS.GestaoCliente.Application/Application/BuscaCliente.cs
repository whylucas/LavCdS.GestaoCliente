using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LavCdS.GestaoCliente.Domain.Interface;
using LavCdS.GestaoCliente.Domain.Model;

namespace LavCdS.GestaoCliente.Application.Application
{
    public class BuscaCliente : IBuscaCliente
    {
        IClienteRepository repository;
        public BuscaCliente(IClienteRepository repository)
        {
            this.repository = repository;
        }

        public async Task<ICliente> getClientePorId(int id_cliente)
        {
            ICliente cliente = repository.getClientePorId(id_cliente);
            return cliente;
        }

        public async Task<List<ICliente>> getClientePorNome(string nome)
        {
            List<ICliente> clientes = repository.getClientePorNome(nome);
            return clientes;
        }
    }
}
