using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gessoft.Model
{
    class Telefone
    {


        
        private string  Residencial;
        private string  Celular;
        
        public string   NResidencial
        {
            get { return Residencial; }
            set { Residencial = value; }
        }
        public string   NCelular
        {
            get { return Celular; }
            set { Celular = value; }
        }
    }
}
