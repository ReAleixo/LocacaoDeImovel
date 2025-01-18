using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoImovel
{
    internal class Locador : Pessoa
    {
        private List<Casa> CasasDoLocador;
        private List<Casa> CasasDisponiveis;

        public Locador(string nome, string cpf, string rg, string sexo, DateTime dataNascimento) 
               : base(nome, cpf, rg, sexo, dataNascimento)
        {
            CasasDoLocador = new List<Casa>();
            CasasDisponiveis = new List<Casa>();
        }

        public List<Casa> getCasasDoLocador()
        {
            return CasasDoLocador;
        }

        public List<Casa> getCasasDisponiveis()
        {
            return CasasDisponiveis;
        }

        public void setCasasDoLocador(Casa casa)
        {
            CasasDoLocador.Add(casa);
            if (!casa.isAlugada())
            {
                setCasasDisponiveis(casa);
            }
        }

        private void setCasasDisponiveis(Casa casa)
        {
            CasasDisponiveis.Add(casa);
        }
    }
}
