using System;

namespace LavCdS.GestaoCliente.Domain.Interface
{
    public interface ICliente
    {
        string Bairro { get; set; }
        string Cep { get; set; }
        string Cidade { get; set; }
        string Complemento { get; set; }
        DateTime Data_inclusao { get; set; }
        int Documento { get; set; }
        string Email { get; set; }
        string Estado { get; set; }
        int Id_cliente { get; set; }
        string Logradouro { get; set; }
        string Num_logradouro { get; set; }
        string Pf_pj { get; set; }
        string Razao_social { get; set; }
        int Telefone1 { get; set; }
        int Telefone2 { get; set; }
    }
}