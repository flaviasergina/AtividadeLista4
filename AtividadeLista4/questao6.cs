using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeLista4
{
    public class questao6
    {
        public static void Executar()
        {
            int x = 0;
            try
            {
                while (true)
                {
                    Console.WriteLine("Digite N a qualquer momento para sair");
                    Console.WriteLine("Digite um valor para ver se é positivo ou não: ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine(VerificaPositivo(x));
                }
            }
            catch (System.FormatException ex)
            {
                return;
            }
        }

        public static bool VerificaPositivo(int numero)
        {
            return numero >= 0;
        }
    }
}