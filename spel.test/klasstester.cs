using System;
using Xunit;
using System.Threading;

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
        [Fact]
        public void TestaBerakning() 
        {
            // arrange - testdata 
            var testobj1 = new cSpel();
            var forvantatResultat = 1000;


            // act - test-case
            testobj1.StartaSpelet();
            Thread.Sleep(forvantatResultat);
            testobj1.StoppaSpelet();
            testobj1.BeraknaReaktionstid();

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal(forvantatResultat, testobj1.Reaktion);

        }
    }
}
