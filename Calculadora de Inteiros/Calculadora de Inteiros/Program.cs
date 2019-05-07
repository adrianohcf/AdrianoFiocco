using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                Console.Write("Digite o dividendo: ");
                int dividendo = int.Parse(Console.ReadLine());

                Console.Write("Quociente: ");
                int quociente = divisor / dividendo;
                Console.WriteLine(quociente);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Erro de divisão por zero: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Estouro de pilha: {e.Message}");
            }
            
        }
    }
}
