using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fisrtName = "Joao";
            string lastName = "Silva";                        
            //comentario
            Console.WriteLine("\n\n" + "Qual é o seu nome?" + "\n");
            Console.WriteLine("Meu nome é {0} {1}",fisrtName, lastName + "\n");

            int idade = 19;
            Console.WriteLine("\n\n" + "Qual é a sua idade?" + "\n");
            Console.WriteLine("Minha idade é {0}", idade + "\n");

            Console.ReadLine();
        }
    }
}
