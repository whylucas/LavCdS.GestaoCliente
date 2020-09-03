using System;
using System.Collections.Generic;
using System.Text;
using LavCdS.GestaoCliente.Domain.Interface;
using LavCdS.GestaoCliente.Domain.Model;
using Npgsql;
using Microsoft.Extensions.Configuration;

namespace LavCdS.GestaoCliente.Infrastructure.Repositories.PostgreSQL
{
    public class ClienteRepository : IClienteRepository
    {
        IConfiguration configuration;
        string connectionString;

        public ClienteRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.connectionString = this.configuration.GetConnectionString("PostgreSQL");
        }

        public Cliente getClientePorId(int id_cliente)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=postgres;Database=teste;");
            Cliente cliente = new Cliente();
            return cliente;
        }

        public List<ICliente> getClientePorNome(string nome)
        {
            List<ICliente> clientes = new List<ICliente>();
            return clientes;
        }

        public bool gravaCliente(ICliente cliente)
        {
            bool result = true;
            return result;
        }

        public bool atualizaCliente(ICliente cliente)
        {
            bool result = true;
            return result;
        }


    }
}
