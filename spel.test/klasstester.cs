using System;
using Xunit;

namespace spel.test
{
    public class Klasstester
    {
        [Fact]
        public void InitConstructor() 
        {
            // arrange - testdata 
            var testobj1 = new cSpel();

            // act - test-case

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.NotNull(testobj1);
        }
    }
}
