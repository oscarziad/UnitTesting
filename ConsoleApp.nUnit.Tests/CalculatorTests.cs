using NUnit.Framework;

namespace ConsoleApp.nUnit.Tests
{
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Theory]
        [TestCase(1,1,2)]
        [TestCase(2,2,4)]
        public void Add_ShouldAddToValues(int value1, int value2, int expected)
        {
            Assert.AreEqual(expected, calc.Add(value1, value2));
        }


        //private Person person;

        //[SetUp]
        //public void Setup()
        //{
        //    person = new Person();
        //}

        //[Test]
        //public void Create_ShouldCreateAPerson()
        //{
        //    var actual = person.Create();
        //    Assert.True(actual);
        //}
    }
}