using System;
using Xunit;

namespace spel.test
{
    public class Typtester
    {
        [Fact]
        public void CheckVariabelTyp() 
        {
            // arrange-section - testdata
            var testobj1 = new cSpel();

            // act-section - test-case

            // assert-section - test av påstående
            // förväntat värde, faktiskt värde
            Assert.IsType(Int32, testobj1.start);
        }
        [Fact]
        public void InitTilldelning() 
        {
            // arrange-section - testdata
            var testobj1 = new cSpel(10);

            // act-section - test-case
            testobj1.Basbelopp = 50;

            // assert-section - test av påstående
            // förväntat värde, faktiskt värde
            Assert.Equal(50, testobj1.Basbelopp);
        }
        [Fact]
        public void Addera() 
        {
            // arrange-section - testdata
            var testobj1 = new cSpel(10);

            // act-section - test-case
            testobj1.BasbeloppPlus = 5;

            // assert-section - test av påstående
            // förväntat värde, faktiskt värde
            Assert.Equal(15, testobj1.Basbelopp);
        }
    }
}
