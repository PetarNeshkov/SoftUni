using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        private Fake.FakeConsoleWriter writer;
        private FizzBuzz fizzBuzz;
        [SetUp]
        public void Setup()
        {
            writer = new Fake.FakeConsoleWriter();
            fizzBuzz = new FizzBuzz(writer);
        }

        [Test]
        public void GivenFizzBuzzWhenNumbersAre1to2ThenResultShouldBeCorrect()
        {
            fizzBuzz.PrintNumbers(1, 2);

            Assert.Pass("12", writer.Result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAre1to3ThenResultShouldBeCorrect()
        {
            fizzBuzz.PrintNumbers(1, 3);

            Assert.Pass("12fizz", writer.Result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAre4to6ThenResultShouldBeCorrect()
        {
            fizzBuzz.PrintNumbers(4, 6);

            Assert.Pass("4buzzfizz", writer.Result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAre14to17ThenResultShouldBeCorrect()
        {
            fizzBuzz.PrintNumbers(14, 17);

            Assert.Pass("14fizzbuzz1617", writer.Result);
        }
        [Test]
        public void GivenFizzBuzzWhenNumbersAreMinus5to2ThenResultShouldBeCorrect()
        {
            fizzBuzz.PrintNumbers(-5, 2);

            Assert.Pass("12", writer.Result);
        }
    }
}