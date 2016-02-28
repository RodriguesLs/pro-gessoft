using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gessoft.Model
{
    class Cliente
    {

        private int     cdCliente;
        private string  nmCliente;
        private string  cpf;
        private string  rg;
        private string  email;
        private string  sexo;

        public int      Codigo
        {
            get { return cdCliente; }
            set { cdCliente = value; }
        }
        public string   Nome
        {
            get { return nmCliente; }
            set { nmCliente = value; }
        }
        public string   CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string   RG
        {
            get { return rg; }
            set { rg = value; }
        }
        public string   Email
        {
            get { return email; }
            set { email = value; }
        }
        public string   Sexo
        {
            get { return sexo; }
            set { sexo = value; }

        }
     
       
    }
}
