using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class cad_pess_fis
{
        public int calcdig1(int CPF)
    {
        int[] numeroscpf = new int[9];
        long restante;
        int somanumeros = 0, digito1;
   

        restante = CPF;
        for (int i = 1; i <= 9; i++)
        {
            numeroscpf[i - 1] = Convert.ToInt32(restante % 10);
            restante = Convert.ToInt32(restante / 10);
            somanumeros = somanumeros + numeroscpf[i - 1] * (i + 1);

        }

        digito1 = 11 - (somanumeros % 11);

        if (digito1 == 2)
        {
            digito1 = 2;
        }
        else if (digito1 >= 10)
        {
            digito1 = 0;
        }
        else
        {
            Console.WriteLine("erro no digito");
        }

        return (digito1);
    }

    public int calcdig2(long CPF_dig1)
    {

        int[] numeroscpf = new int[10];
        long restante;
        int somanumeros = 0, digito2;


        restante = CPF_dig1;
        for (int i = 1; i <= 10; i++)
        {
            numeroscpf[i - 1] = Convert.ToInt32(restante % 10);
            restante = Convert.ToInt32(restante / 10);
            somanumeros = somanumeros + numeroscpf[i - 1] * (i + 1);
        }
        digito2 = 11 - (somanumeros % 11);

        if (digito2 == 2)
        {
            digito2 = 2;
        }
        else if (digito2 >= 10)
        {
            digito2 = 0;
        }
        else
        {
            Console.WriteLine("erro no digito");
        }

        return (digito2);
    }

    public void mensagem(int CPF_digitado)
    {
        int dig1 = calcdig1(CPF_digitado);

        long dig2 = calcdig2(long.Parse(CPF_digitado+""+dig1));

        Console.WriteLine("O seu CPF com digito é: " + CPF_digitado + "-" + dig1 + dig2);
        Console.ReadLine();


    }


}
