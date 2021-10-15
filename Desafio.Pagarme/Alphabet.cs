using System.Collections.Generic;

namespace Desafio.Pagarme
{
    public class Alphabet
    {
        public IDictionary<char, int> Dictionary { get; private set; }// uma coleção de chave/valor usei para guardar os valores
        public Alphabet()
        {
            Dictionary = new Dictionary<char, int>()//adiciona valor a cada letra do alfabeto, a-z 1-26 e A-Z 27-52
            {
                //MINÚSCULAS 
                { 'a', 1 },
                { 'b', 2 },
                { 'c', 3 },
                { 'd', 4 },
                { 'e', 5 },
                { 'f', 6 },
                { 'g', 7 },
                { 'h', 8 },
                { 'i', 9 },
                { 'j', 10 },
                { 'k', 11 },
                { 'l', 12 },
                { 'm', 13 },
                { 'n', 14 },
                { 'o', 15 },
                { 'p', 16 },
                { 'q', 17 },
                { 'r', 18 },
                { 's', 19 },
                { 't', 20 },
                { 'u', 21 },
                { 'v', 22 },
                { 'w', 23 },
                { 'x', 24 },
                { 'y', 25 },
                { 'z', 26 },

                //MAIÚSCULAS
                { 'A', 27 },
                { 'B', 28 },
                { 'C', 29 },
                { 'D', 30 },
                { 'E', 31 },
                { 'F', 32 },
                { 'G', 33 },
                { 'H', 34 },
                { 'I', 35 },
                { 'J', 36 },
                { 'K', 37 },
                { 'L', 38 },
                { 'M', 39 },
                { 'N', 40 },
                { 'O', 41 },
                { 'P', 42 },
                { 'Q', 43 },
                { 'R', 44 },
                { 'S', 45 },
                { 'T', 46 },
                { 'U', 47 },
                { 'V', 48 },
                { 'W', 49 },
                { 'X', 50 },
                { 'Y', 51 },
                { 'Z', 52 },
            };
        }
    }
}
