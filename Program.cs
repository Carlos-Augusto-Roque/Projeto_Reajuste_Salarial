using System;

namespace Projeto_Reajuste_Salarial
{
    class Program
    {
        static void Main(string[] args)
        {

            //variáveis
            decimal salario, salarioReajustado;

            //entrada de dados
            Console.WriteLine("Digite o Salário atual");
            salario = decimal.Parse(Console.ReadLine());

            //processamento
            
            salarioReajustado = (salario + (30*salario)/100);
            

            if(salario<500){ 
                //valor verdadeiro
                Console.WriteLine("O Salário Reajustado é: "+salarioReajustado+ " Reais ");
            }
            else{
                //valor falso
                Console.WriteLine("O funcionário não tem direito ao aumento");
            }
        }
    }
}
