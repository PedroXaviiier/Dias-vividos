/*Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir
quantos dias de vidaela possui. Considere sempre anos completos, e que um
ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja
um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
*/





using System;

namespace Dias_vividos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe sua idade: ");
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{nome}, você viveu {idade * 365} dias");
        }
    }
}
