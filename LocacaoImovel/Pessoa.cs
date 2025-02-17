﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoImovel
{
    public abstract class Pessoa
    {
        private int ID { get; }
        private string Nome { get; set; }
        private string CPF { get; set; }
        private string RG { get; set; }
        private string Sexo { get; set; }
        private DateTime DataNascimento { get; set; }

        public Pessoa(string nome, string cpf, string rg, string sexo, DateTime dataNascimento)
        {
            setNome(nome);
            setCPF(cpf);
            setRG(rg);
            setSexo(sexo);
            setDataNascimento(dataNascimento);
        }

        #region Getters Methods

        protected int getID()
        {
            return ID;
        }

        protected string getNome()
        {
            return Nome;
        }

        protected string getCpf()
        {
            return CPF;
        }

        protected string getRg() 
        { 
            return RG;
        }

        protected string getSexo() 
        {
            return Sexo;
        }

        protected DateTime getDataNascimento()
        {
            return DataNascimento;
        }

        #endregion

        #region Setters Methods

        protected void setNome(string nome)
        {
            Nome = nome;
        }

        protected void setCPF(string cpf)
        {
            CPF = cpf;
        }

        protected void setRG(string rg)
        {
            RG = rg;
        }

        protected void setSexo(string sexo)
        {
            Sexo = sexo;
        }

        protected void setDataNascimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }

        #endregion
    }
}
