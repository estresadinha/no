using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novo
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public double altura;
        public double peso;
        public double imc;
        public int anoatual;
        public int anonac;

        public void CalculaIMC(double peso,double altura)
        {
            this.peso = peso;
            this.altura = altura;
            imc = this.peso / (this.altura* this.altura);
        }

        public void CalculaIdade(int anoatual,int anonac)
        {
            this.anoatual = anoatual;
            this.anonac = anonac;
            idade = this.anoatual-this.anonac;

        }
      

    }
      
}
