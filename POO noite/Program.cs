using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_noite
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //em Python print = apresenta conteúdo de texo ou variável
            Console.Write("Digite o ano de nascimento: ");

            //em Python anon = int(input('Digite o ano de nascimento: '))
            int anon = Convert.ToInt32(    Console.ReadLine()   );
            Console.WriteLine("Sua idade é " + (2022 - anon) + " anos.");

            Console.Write("Digite a média: ");
            double media = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nExemplo do comando if.........");
            //em Python if media >= 6:   elif    else  && == and  || == or
            if (media >= 6 && media < 10) 
                Console.WriteLine("Aprovado"); //cw tab tab
            else if (media == 10)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("com louvor!!!!");
            }
            else
                Console.WriteLine("Reprovado");

            Console.WriteLine("\nExemplo do comando for.........");
            //em Python for contador in range(4):
            for (contador = 0; contador < 4; contador ++)
                Console.WriteLine(contador);
            
            Console.WriteLine("\nExemplo do comando while.........");
            //em Python while contador < 4:            
            int contador = 0;
            while (contador < 4)
            {
                Console.WriteLine(contador);
                contador = contador + 1; // contador += 1 ou contador ++
            }
            Console.WriteLine("\nExemplo do comando do .. while .........");
            //em Python não tem do .. while
            contador = 0;
            do
            {                
                Console.WriteLine(contador);
                contador = contador + 1; // contador += 1 ou contador ++
            } while (contador < 4);
            */
            Console.Write("Digite o salário.. zero para encerrar: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            double soma = 0;
            while (salario > 0)
            {
                soma = soma + salario; // soma += salario;
                Console.Write("Digite o salário, zero para encerrar: ");
                salario = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Resultado da soma de salários R$ " + soma);
            Console.WriteLine("\nExemplo do comando do .. while .........");
            soma = 0;
            do
            {
                Console.Write("Digite o salário, zero para encerrar: ");
                salario = Convert.ToDouble(Console.ReadLine());
                if (salario > 0)
                    soma = soma + salario; // soma += salario;
            } while (salario > 0);
            Console.WriteLine("Resultado da soma de salários R$ " + soma);
            Console.ReadKey();//função usada para pausar a tela do prompt de comando
        }
    }
}
 