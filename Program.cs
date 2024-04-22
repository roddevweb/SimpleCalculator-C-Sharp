using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entrez le premiere nombre: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez le deuxième nombre");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int addition = number1 + number2;
            int soustraction = number1 - number2;
            int multiplication = number1 * number2;
            int division = number1 / number2;

            Console.WriteLine("Addition: " + addition);
            Console.WriteLine("Soustraction: " + soustraction);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Division: " + division);

            Console.ReadLine();

        }
    }
}
