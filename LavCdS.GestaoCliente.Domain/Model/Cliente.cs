using System;
using System.Collections.Generic;
using System.Text;
using LavCdS.GestaoCliente.Domain.Interface;

namespace LavCdS.GestaoCliente.Domain.Model
{
    public class Cliente : ICliente
    {
        private int id_cliente;
        private string razao_social;
        private string pf_pj;
        private int documento;
        private string email;
        private int telefone1;
        private int telefone2;
        private string logradouro;
        private string num_logradouro;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        private DateTime data_inclusao;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Razao_social { get => razao_social; set => razao_social = value; }
        public string Pf_pj { get => pf_pj; set => pf_pj = value; }
        public int Documento { get => documento; set => documento = value; }
        public string Email { get => email; set => email = value; }
        public int Telefone1 { get => telefone1; set => telefone1 = value; }
        public int Telefone2 { get => telefone2; set => telefone2 = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Num_logradouro { get => num_logradouro; set => num_logradouro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
        public DateTime Data_inclusao { get => data_inclusao; set => data_inclusao = value; }
    }
}
