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

            float num1, num2;

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt64(Console.ReadLine());



            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt64(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("El divisor no puede ser 0. la operacion no se puede realizar");
            }


            else
            {
                Console.WriteLine("Numero 1 / Numero 2 = "+ num1 / num2 );
                Console.WriteLine("El resto de la division es " + num1 % num2);
            }
            
            
            
            
            
            Console.ReadLine();



        
        
        }
    }
}
