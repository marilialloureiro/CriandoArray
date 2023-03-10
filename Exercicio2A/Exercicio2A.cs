using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2A
{
    public class Exercicio2A
    {
        //Desenvolvam um programa que armazene uma lista de convidados utilizando um array.
        public static void Main()
        {
            string[] convidados = new string[5];

            convidados[0] = "João";
            convidados[1] = "Maria";
            convidados[2] = "Mariana";
            convidados[3] = "Eduardo";
            convidados[4] = "José";

            Console.WriteLine("O número de convidados é igual a " + convidados.Length);
        }

    }
      
}
