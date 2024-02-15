namespace MyTools.Tests
{
    public class MyToolsTests
    {
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(97)]
        [Theory]
        public void ValidIsPrimeTest(int value)
        {
            //Arrange (Préparer le test)
            int x = value;
            //Act (Appeler la fonctionnalite)
            bool isPrime = x.IsPrime();

            //Assert (Tester le résultat obtenu)
            Assert.True(isPrime);
        }

        [InlineData(4)]
        [InlineData(9)]
        [InlineData(21)]
        [InlineData(25)]
        [InlineData(32)]
        [InlineData(49)]
        [Theory]
        public void InvalidIsPrimeTest(int value)
        {
            //Arrange (Préparer le test)
            int x = value;
            //Act (Appeler la fonctionnalite)
            bool isPrime = x.IsPrime();

            //Assert (Tester le résultat obtenu)
            Assert.False(isPrime);
        }

        [Fact]
        public void OneIsNotPrime()
        {
            //Arrange (Préparer le test)
            int x = 1;
            //Act (Appeler la fonctionnalite)
            bool isPrime = x.IsPrime();

            //Assert (Tester le résultat obtenu)
            Assert.False(isPrime);
        }

        [Fact]
        public void ZeroIsNotPrime()
        {
            //Arrange (Préparer le test)
            int x = 0;
            //Act (Appeler la fonctionnalite)
            bool isPrime = x.IsPrime();

            //Assert (Tester le résultat obtenu)
            Assert.False(isPrime);
        }

        [InlineData(-4)]
        [InlineData(-9)]
        [InlineData(-21)]
        [InlineData(-25)]
        [InlineData(-32)]
        [InlineData(-49)]
        [Theory]
        public void NegativeNumbersAreError(int value)
        {
            //Arrange (Préparer le test)
            int x = value;
            //Act (Appeler la fonctionnalite)
            Assert.Throws<InvalidOperationException>(() => x.IsPrime());
        }

        [InlineData(-4, "This number '-4' is not valid")]
        [InlineData(-9, "This number '-9' is not valid")]
        [InlineData(-21, "This number '-21' is not valid")]
        [InlineData(-25, "This number '-25' is not valid")]
        [InlineData(-32, "This number '-32' is not valid")]
        [InlineData(-49, "This number '-49' is not valid")]
        [Theory]
        public void NegativeNumbersAreNotPrime(int value, string expectedMessage)
        {
            //Arrange (Préparer le test)
            int x = value;
            //Act (Appeler la fonctionnalite)
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => x.IsPrime());

            //Assert (Tester le résultat obtenu)
            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}