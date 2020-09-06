using System.Collections.Generic;
using LavCdS.GestaoCliente.Domain.Model;

namespace LavCdS.GestaoCliente.Domain.Interface
{
    public interface IClienteRepository
    {
        bool atualizaCliente(ICliente cliente);
        Cliente getClientePorId(int id_cliente);
        List<ICliente> getClientePorNome(string nome);
        bool gravaCliente(ICliente cliente);
    }
}