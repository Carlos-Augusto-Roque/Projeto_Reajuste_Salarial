using System;

namespace Projeto_Reajuste_Salarial
{
    class Program
    {
        static void Main(string[] args)
        {

            //variáveis
            decimal salario, salarioReajustado, reajuste =0;

            //entrada de dados
            Console.WriteLine("Digite o Salário atual");
            salario = decimal.Parse(Console.ReadLine());

           
         

            if(salario<500){ 
               
                Console.WriteLine("insira o reajuste percentual");
                reajuste = decimal.Parse(Console.ReadLine());
                 //processamento
                salarioReajustado = (reajuste*salario)/100;
                
                // Console.WriteLine("O valor do reajuste foi de: " +reajuste+ " Reais ");
                Console.WriteLine("O valor do reajuste foi de: " +salarioReajustado+ " Reais ");
            }
            else{
                //valor falso
                Console.WriteLine("O funcionário não tem direito ao aumento");
            }

        }
    }
}
