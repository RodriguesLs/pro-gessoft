using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gessoft.Model
{
    class Funcionario
    {
        private int     cdFuncionario;
        private string  nmFuncionario;
        private string  cpf;
        private string  rg;
        private string  email;
        private string  sexo;

        // Carai quanta coisa O.o
        private string  carteriraTrabalaho;
        private string  serie;
        private string  icFilhos; // Tem filhos? retorno bool;
        private string  nmPai;
        private string  nmMae;
        private string  qtFilhos;
        private string  reservista;
        private string  cdReservista;
        private string  dtNascimento;
        private string  depto;
        private string  cargo;

        public int      Codigo
        {
            get { return cdFuncionario; }
            set { cdFuncionario = value; }
        }
        public string   Nome
        {
            get { return nmFuncionario; }
            set { nmFuncionario = value; }
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
        public string   NCarteira {
            get { return carteriraTrabalaho; }
            set { carteriraTrabalaho = value; }
        }
        public string   NSerie
        {
            get { return serie; }
            set { serie = value; }
        }
        public string   TemFilhos
        {
            get { return icFilhos; }
            set { icFilhos = value; }
        }
        public string   NomePai
        {
            get { return nmPai; }
            set { nmPai = value; }
        }
        public string   NomeMae
        {
            get { return nmMae; }
            set { nmMae = value; }
        }
        public string   QuantosFilhos {
            get {   return qtFilhos; }
            set { qtFilhos = value; }
        }
        public string   TemReservista {
            get { return reservista; }
            set { reservista = value; }
        }
        public string   NReservista {
            get { return cdReservista; }
            set { cdReservista = value; }
        }
        public string   Nasimento {
            get { return dtNascimento; }
            set { dtNascimento = value; }
        }
        public string   Depto {
            get { return depto; }
            set { depto = value; }
        }
        public string   Cargo{
            get { return cargo; }
            set { cargo = value; }
        }
    }
}
