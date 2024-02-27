using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeConsole2702
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Qual a distancia percorrida? ");
            int km = int.Parse(Console.ReadLine());

            Console.WriteLine("qual foi o consumo do veiculo em litros? ");
            double consumo = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do combustivel usado para abastecer? ");
            double valor = double.Parse(Console.ReadLine()); 

            double distancia = km / consumo;

            double gasto = distancia * valor;

            Console.WriteLine("O valor gasto será de: " + gasto);
            Console.ReadKey();
        
        }
    }
}
