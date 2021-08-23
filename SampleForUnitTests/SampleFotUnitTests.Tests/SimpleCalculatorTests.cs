using SampleForUnitTests;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SampleFotUnitTests.Tests
{
    public class SimpleCalculatorTests
    {
        [Fact]
        public void GetSum_2_Plus_5_Eq_7()
        {
            //Arrange
            SimpleCalculator calculator = new SimpleCalculator();

            //Act
            var resulr = calculator.GetSum(2, 5);

            //Assert
            Assert.Equal( 7, resulr);
        }

        [Fact]

        public void GetSubstruct_5_Min_2_Eq_3()
        {

            //Arrange
            SimpleCalculator calculator = new SimpleCalculator();

            //Act
            var resulr = calculator.GetSubstruct(5, 2);

            //Assert
            Assert.Equal(3, resulr);
        }
    }
}
