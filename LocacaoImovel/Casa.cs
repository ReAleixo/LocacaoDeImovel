using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoImovel
{
    public class Casa
    {
        private int NumeroCasa { get; set; }
        private int NumeroComodos { get; set; }
        private int MetrosQuadrados { get; set; }
        private float ValorAluguel { get; set; }
        private bool Alugada { get; set; }
        private Locatario Locatario { get; set; }

        public Casa(int numeroComodos, int metrosQuadrados, float valorAluguel)
        {
            NumeroComodos = numeroComodos;
            MetrosQuadrados = metrosQuadrados;
            ValorAluguel = valorAluguel;
            Alugada = false;
            Locatario = null;
            NumeroCasa = 0;
        }

        #region Getters Methods

        public int getNumeroCasa()
        {
            return NumeroCasa; 
        }

        public int getNumeroComodos() 
        {
            return NumeroComodos;
        }

        public int getMetrosQuadrados()
        {
            return MetrosQuadrados;
        }

        public float getValorAluguel()
        {
            return ValorAluguel;
        }

        public bool isAlugada()
        {
            return Alugada;
        }

        public Locatario getLocatario()
        {
            return Locatario; 
        }

        #endregion

        #region Setters Methods

        public void setNumeroCasa(int numeroCasa)
        {
            NumeroCasa = numeroCasa;
        }

        public void setNumeroComodos(int numeroComodos)
        {
            NumeroComodos = numeroComodos;
        }

        public void setMetrosQuadrados(int metrosQuadrados)
        {
            MetrosQuadrados = metrosQuadrados;
        }

        public void setValorAluguel(float valorAluguel)
        {
            ValorAluguel = valorAluguel;
        }

        public void setAlugada(bool alugada)
        {
            Alugada = alugada;
        }

        public void setLocatario(Locatario locatario)
        {
            Locatario = locatario;
        }

        #endregion
    }
}
