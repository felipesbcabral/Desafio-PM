using System;
using System.Text.RegularExpressions;

namespace Desafio.Pagarme
{
    public class Word
    {
        public string Texto { get; private set; }
        public Alphabet Dicionario { get; private set; }
        public int Resultado { get; private set; }

        public Word(string texto, Alphabet dicionario)
        {
            Texto = texto;
            Dicionario = dicionario;
        }

        public bool ValidateInput()//método que verifica se os caracteres do input enviado está correto, e também remove os espaços em brancos, se estiver fora do regex definido ele retorna inválido.
        {
            Texto = Texto.Replace(" ", string.Empty);
            var rgx = new Regex("^[A-Za-z ]+$");
            Match match = rgx.Match(Texto);
            return match.Success;
        }

        public bool IsPrime()//método que verifica se o input/palavra enviado é primo ou não, para fazer isso ele soma os valores da palavra e retorna o resultado.
        {
            int resultado = 0;
            int numDivisores = 0;

            foreach (var c in Texto)
            {
                Dicionario.Dictionary.TryGetValue(c, out int n);
                Console.WriteLine(n);

                resultado += n;
            }

            for (int i = 1; i <= resultado; i++)
            {
                if (resultado % i == 0)
                {
                    numDivisores++;
                }
            }
            Resultado = resultado;
            return numDivisores == 2;
        }
    }
}
