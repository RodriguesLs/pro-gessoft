using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gessoft.Model
{
    class AgendaServico
    {

        private int cdservico;
        private int cdusuario;
        private int cdcliente;
        private int cdendereco;
        private string nmsevico;
        private string descricao;
        private double valor;
        private string cdOrcamento;
        private string cdServico;
        private string mes;
        private string dia;
        private string ano;
        private string geracao;
        private string cdStatus;



        public int Codigo
        {
            get { return cdservico; }
            set { cdservico = value; }
        }
        public int CodigoUsuario
        {
            get { return cdusuario; }
            set { cdusuario = value; }
        }
        public int CodigoCliente
        {
            get { return cdcliente; }
            set { cdcliente = value; }
        }
        public int CodigoEndereco
        {
            get { return cdendereco; }
            set { cdendereco = value; }
        }
        public string Nome
        {
            get { return nmsevico; }
            set { nmsevico = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public string CdOrcamento {
            get { return cdOrcamento; }
            set { cdOrcamento = value; }
        }
        public string CdServico {
            get { return cdServico; }
            set { cdServico = value; }
        
        }
        public string Mes {
            get { return mes; }
            set { mes = value; }
        }
        public string Dia {
            get { return dia; }
            set { dia = value; }
        }
        public string Ano {
            get { return ano; }
            set { ano = value; }
        }
        public string Geracao {
            get { return geracao; }
            set { geracao = value; }
        }
        public string CdStatus
        {
            get { return cdStatus; }
            set { cdStatus = value; }
        }

    }
}
