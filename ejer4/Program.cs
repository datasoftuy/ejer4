using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejer4
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2;

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("El divisor no puede ser 0");
            }


            else
            {
                Console.WriteLine("Numero 1 / Numero 2 ="+ num1 / num2 );
                Console.WriteLine("Y su resto es " + num1 % num2);
            }
            
            
            
            
            
            Console.ReadLine();



        
        
        }
    }
}
