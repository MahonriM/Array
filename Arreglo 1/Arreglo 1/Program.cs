using System;
using System.Collections.Generic;

namespace Arreglo_1
{
    class Program
    {
         static void Main(string[] args)
        {/*Hacer un programa que declare un arreglo de una dimensión con
          valores predefinidos y los muestre.*/
            int[] numeros= { 0,1,2,3,5,8,10,11,15,20};
            foreach (int i in numeros)
            {
                Console.WriteLine("{0}", i);
            }

            //Pausa
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
            
        }
        
            
        
    }
}
