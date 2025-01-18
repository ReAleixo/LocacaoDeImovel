using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoImovel
{
    public class Locador : Pessoa
    {
        private List<Casa> CasasDoLocador { get; set; }
        private List<Casa> CasasDisponiveis { get; set; }

        public Locador(string nome, string cpf, string rg, string sexo, DateTime dataNascimento) 
               : base(nome, cpf, rg, sexo, dataNascimento)
        {
            CasasDoLocador = new List<Casa>();
            CasasDisponiveis = new List<Casa>();
        }

        #region Getters Methods

        public List<Casa> getCasasDoLocador()
        {
            return CasasDoLocador;
        }

        public List<Casa> getCasasDisponiveis()
        {
            return CasasDisponiveis;
        }

        #endregion

        #region Setters Methods

        public void setCasasDoLocador(Casa casa)
        {
            CasasDoLocador.Add(casa);
            if (!casa.isAlugada())
            {
                setCasasDisponiveis(casa);
            }
        }

        public void setCasasDisponiveis(Casa casa)
        {
            CasasDisponiveis.Add(casa);
        }

        #endregion
    }
}
