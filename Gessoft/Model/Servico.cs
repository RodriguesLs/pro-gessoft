using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gessoft.Model
{
    class Servico
    {
        private int cdservico;
        private int cdusuario;
        private int cdcliente;
        private int cdendereco;
        private string nmsevico;
        private string descricao;
        private double valor;
        


        public int Codigo {
            get { return cdservico;  }
            set { cdservico = value;  }
        }
        public int CodigoUsuario {
            get { return cdusuario; }
            set { cdusuario = value; }
        }
        public int CodigoCliente {
            get { return cdcliente; }
            set { cdcliente = value; }
        }
        public int CodigoEndereco {
            get { return cdendereco; }
            set { cdendereco = value; }
        }
        public string Nome {
            get { return nmsevico;  }
            set { nmsevico = value; }
        }
        public string Descricao {
            get { return descricao;  }
            set { descricao = value;  } 
        }
        public double Valor {
            get { return valor; }
            set { valor = value;  }
        }

    }
}
