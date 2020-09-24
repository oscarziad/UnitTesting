using ConsoleApp;
using System;
using Xunit;

namespace ConsoleAppXUnitTests
{
    public class CalculatorTests
    {
        // TDD - Test Driven Development
        // Enhetstest (Unit Test), Integrationstest (Integration Test), Början till slut test (End to End Test)
        //RED, GREEN, REFACT


        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void Add_ShouldAddToValues(int value1, int value2, int expected)
        {
            var calc = new Calculator();
            int actual = calc.Add(value1, value2);
            Assert.Equal(expected, calc.Add(value1, value2));
        }   
        

        //[Fact]
        //public void Create_ShouldCreate()
        //{
        //    var person = new Person();
        //    bool actual = person.Create();
        //    Assert.True(actual);
        //}
    }
}
