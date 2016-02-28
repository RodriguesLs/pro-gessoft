using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gessoft.Model
{
    class Fornecedor
    {

        private int cdFornecedor;
        private string nmRazao;
        private string nmFantasia;
        private string cnpj;
        private string email;
        

        public int Codigo
        {
            get { return cdFornecedor; }
            set { cdFornecedor = value; }
        }
        public string Razao
        {
            get { return nmRazao; }
            set { nmRazao = value; }
        }
        public string Fantasia
        {
            get { return nmFantasia; }
            set { nmFantasia = value; }
        }
        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
    }
}
