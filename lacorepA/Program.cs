using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lacoInterativo
{
    class Program
    {
        static void Main(string[] args)
        {
            //lacos interativos
            for (int i=0; i<10; i++) //++ quer dizer que vai ser somado de um em um
            {
                Console.WriteLine("Valor de i é " + i);
            }

             //while
             int contador = 4;
            while (contador < 10)
            {
                Console.WriteLine(contador);
                contador ++;

            }

            //Do .. while
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;

            }while(j < 140);
           
           //foreach
           //percorre todos os elementos do conjunto
           int[] conjunto = {0, 1, 2, 3, 4};
           foreach (int numero in conjunto)
           {
            Console.WriteLine("esse elemento do conjunto em valor é " +numero);
           }

           int[] conjunto2 = {0, 5, 10, 150};
           foreach (int numero2 in conjunto2)
           {
            Console.WriteLine("os elementos desse segundo conjunto são " + numero2 + "mas se multiplicar por 10 " + (numero2 * 10));

           }
        }
    }

}