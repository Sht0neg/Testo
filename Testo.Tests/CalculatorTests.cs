namespace Testo.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calc;    
        [SetUp]

        public void Setup() {
            calc = new Calculator();
        }

        [Test]
        public void Add() {
            var calc = new Calculator();
            Assert.That(calc.Add(2, 3) == 5);
        }
        [Test]
        public void Sub()
        {
            var calc = new Calculator();
            Assert.That(calc.Sub(4, 1) == 3);
        }
    }
}