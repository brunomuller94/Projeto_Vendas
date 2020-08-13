using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Vendas
{
    class Cliente
    {
        //Atributos, propriedades e caracteristicas
        //Construtor - ctor (tabtab)
        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }
        //public string Nome { get; set; } - Criar get e set publicos com classe privada
        //prop + ctrl space
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}";
        }
    }
}
