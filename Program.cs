using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            long CPF;

            Console.WriteLine("Por favor digite o seu CPF");
            CPF = long.Parse(Console.ReadLine());
            if (CPF <= 1000000000 && CPF >= 99999999)
            {
                cad_pess_fis a = new cad_pess_fis();

                a.mensagem(Convert.ToInt32(CPF));

            }
            else
            {
                Console.WriteLine("CPF inválido, Digite um CPF de 9 digitos!");
                Console.ReadLine();
            }

        }
    }
}
