using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Calculadora
{
    public class Funcoes
    {
        public virtual int MenuPrincipal()
        {
            int selecao;
            int opcoes = 3;
            do
            {
                Console.WriteLine("Escolha sua opção");
                Console.WriteLine("------------------");
                Console.WriteLine("01 - Soma");
                Console.WriteLine("02 - Multiplicacao");
                Console.WriteLine("03 - Divisao");
                Console.WriteLine("------------------");
                Console.WriteLine("00 - Sair");
                selecao = Convert.ToInt32(Console.ReadLine());
            }while(selecao < 0 || selecao > opcoes);
            return selecao;
        }
        public virtual int Soma()
        {
            int Total, Valor1, Valor2;
            Console.WriteLine("Primeiro valor: ");
            Valor1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            Valor2= Convert.ToInt32(Console.ReadLine());
            Total = Valor1 + Valor2;
            Console.WriteLine("Valor total = " + Total);
            return Total;
        }
        public virtual int Multiplicacao()
        {
            int Total, Valor1, Valor2;
            Console.WriteLine("Primeiro valor: ");
            Valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            Valor2 = Convert.ToInt32(Console.ReadLine());
            Total = Valor1 * Valor2;
            Console.WriteLine("Valor total = " + Total);
            return Total;
        }
        public virtual int Divisao()
        {
            int Total, Valor1, Valor2;
            Console.WriteLine("Primeiro valor: ");
            Valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            Valor2 = Convert.ToInt32(Console.ReadLine());
            Total = Valor1 / Valor2;
            Console.WriteLine("Valor total = " + Total);
            return Total;
        }
    }
}
