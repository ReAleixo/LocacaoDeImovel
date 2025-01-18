using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoImovel
{
    public class Locatario : Pessoa
    {
        private bool ProcurandoCasaParaAlugar { get; set; }
        private Casa CasaDesejada { get; set; }

        public Locatario(string nome, string cpf, string rg, string sexo, DateTime dataNascimento)
               : base(nome, cpf, rg, sexo, dataNascimento)
        {
            setProcurandoCasaParaAlugar(true);
        }

        #region Getters Methods

        public bool getProcurandoCasaParaAlugar()
        {
            return ProcurandoCasaParaAlugar;
        }

        public Casa getCasaDesejada()
        {
            return CasaDesejada;
        }

        #endregion

        #region Setters Methods

        public void setProcurandoCasaParaAlugar(bool procurandoCasaParaAlugar)
        {
            ProcurandoCasaParaAlugar = procurandoCasaParaAlugar;
        }

        public void setCasaDesejada(int numeroComodos, int metrosQuadrados, float valorAluguel) 
        {
            CasaDesejada = new Casa(numeroComodos, metrosQuadrados, valorAluguel);
        }

        #endregion
    }
}
