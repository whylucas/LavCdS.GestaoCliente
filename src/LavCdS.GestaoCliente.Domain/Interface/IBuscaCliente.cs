using System.Collections.Generic;
using System.Threading.Tasks;

namespace LavCdS.GestaoCliente.Domain.Interface
{
    public interface IBuscaCliente
    {
        Task<ICliente> getClientePorId(int id_cliente);
        Task<List<ICliente>> getClientePorNome(string nome);
    }
}