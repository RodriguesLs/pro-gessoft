using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gessoft.Model
{
    class Endereco
    {
        private int     cdEndereco;
        private string  rua;
        private string  bairro;
        private string  cidade;
        private string  estado;
        private string  cep;
        private string  numero;
        private string complemento;

        public int      CdEndereco
        {
            get { return cdEndereco; }
            set { cdEndereco = value; }
        }
        public string   Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string   Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string   Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string   Estado
        {
            get { return estado; }
            set { estado = value; }

        }
        public string   Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string   Numero {
            get { return numero; }
            set { numero = value; }
        }
        public string   Complemento {
            get { return complemento; }
            set { complemento = value;  }

        }

    }
}
