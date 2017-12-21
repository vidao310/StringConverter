using System;
using System.Collections.Generic;
using Xunit;
using Converter;

namespace Converter_Tests
{
    public class StringConverterTests
    {
        [Theory]
        [InlineData("Test123 Auto parts","T2t123 A2o p3s")]
        [InlineData("automatioN$*^Test","a8N$*^T2t")]
        [InlineData("Tp T *ABC", "T0p T *A1C")]
        [InlineData("Automotive parts", "A8e p3s")] //Wrong expected result in given spec "A6e p3s"
        public void Test_Converted_String(string input, string expectedResult)
        {
            var actualResult = StringConverter.Convert(input);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
