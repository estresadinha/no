using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Console.WriteLine("digite seu nome ");
            pessoa1.nome = Console.ReadLine();
           

            Console.WriteLine("digite sua altura ");
            pessoa1.altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite seu peso ");
            pessoa1.peso = Convert.ToDouble(Console.ReadLine());


            pessoa1.CalculaIMC(pessoa1.peso,pessoa1.altura);
            Console.WriteLine("o imc de " + pessoa1.nome+ "é " + pessoa1.imc);


            Console.WriteLine("digite ano atual ");
            pessoa1.anoatual= Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("digite ano nascimento ");
            pessoa1.anonac = Convert.ToInt32(Console.ReadLine());

            pessoa1.CalculaIdade (2023,pessoa1.anonac);
            Console.WriteLine("idade  " + pessoa1.idade + " anos " );


        }
        

    }
}
