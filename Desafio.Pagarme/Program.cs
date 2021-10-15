using System;

namespace Desafio.Pagarme
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Digite a palavra: ");
            Alphabet dicionario = new();
            Word word = new(Console.ReadLine(), dicionario);
            var isValid = word.ValidateInput();
            if (isValid)//se o input passado for valido ele passa se não ele retorna inválido
            {
                Console.WriteLine("Palavra valida.");
            }
            else
            {
                Console.WriteLine("Plavra invalida.");
                return;
            }
            var isPrime = word.IsPrime();//retorna a soma da palavra e o calculo se a palavra é prima.
            if (isPrime)
            {
                Console.WriteLine("A soma dos valores é: " + word.Resultado + " - A palavra digitada é prima");
            }
            else
            {
                Console.WriteLine("A soma dos valores é: " + word.Resultado + " - A palavra digitada não é prima");
            }
        }
    }
}