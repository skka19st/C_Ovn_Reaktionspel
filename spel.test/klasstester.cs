using System;
using Xunit;

namespace spel.test
{
    public class Klasstester
    {
        [Fact]
        public void InitConstructor() 
        {
            // arrange-section - testdata 
            var testobj1 = new cSpel();

            // act-section - test-case

            // assert-section - test av påstående
            // förväntat värde, faktiskt värde
            Assert.NotNull(testobj1);
        }
    }
}
