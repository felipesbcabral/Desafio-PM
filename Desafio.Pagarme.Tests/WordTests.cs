using Xunit;

namespace Desafio.Pagarme.Tests
{
    public class WordTests
    {
        [Fact]
        public void Should_Validate_Input_Be_True()//O input deve retornar True
        {
            var word = "Felipe";
            Alphabet dicionario = new Alphabet();
            Word palavra = new(word, dicionario);
            bool isValid = palavra.ValidateInput();

            Assert.True(isValid);
        }

        [Fact]
        public void Should_Validate_Input_Be_False()// O input deve ser Falso
        {
            var word = "Fe}^`}";
            Alphabet dicionario = new Alphabet();
            Word palavra = new(word, dicionario);
            bool isValid = palavra.ValidateInput();

            Assert.False(isValid);
        }

        [Fact]
        public void Should_Validate_Word_Be_Prime()//O input deve ser primo
        {
            var prime = "Felipe";
            Alphabet dicionario = new Alphabet();
            Word palavra = new(prime, dicionario);
            bool isPrime = palavra.IsPrime();

            Assert.True(isPrime);
        }

        [Fact]
        public void Should_Validate_Word_Be_Not_Prime()// O input não deve ser primo
        {
            var prime = "Eduardo";
            Alphabet dicionario = new Alphabet();
            Word palavra = new(prime, dicionario);
            bool isPrime = palavra.IsPrime();

            Assert.False(isPrime);
        }
    }
}
