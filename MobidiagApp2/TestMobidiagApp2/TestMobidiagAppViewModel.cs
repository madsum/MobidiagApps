using MobidiagApp2.ViewModel;
using System;
using Xunit;

namespace TestMobidiagApp2
{
    public class TestMobidiagAppViewModel : IDisposable
    {
        private MobidiagAppViewModel mobidiagAppViewModel;
        public TestMobidiagAppViewModel()
        {
            mobidiagAppViewModel = new MobidiagAppViewModel();
        }

        public void Dispose()
        {
            // nothing to clean up. 
        }

        [Fact]
        public void TestGetMultiples()
        {
            // Arrange
            ulong expectedResult = 8;
            ulong expectedResult2 = 234168;

            // Act
            ulong actualResult = mobidiagAppViewModel.GetTotalMutiple("5");
            ulong acutalResult2 = mobidiagAppViewModel.GetTotalMutiple("1000");

            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedResult2, acutalResult2);
        }

        [Fact]
        public void TestGetTotalMutipleInput()
        {
            // Arrange
            ulong expectedResult = 1;
            ulong expectedResult2 = 1000;

            // Act
            ulong actualResult = mobidiagAppViewModel.GetTotalMutipleInput("1");
            ulong actualResult2 = mobidiagAppViewModel.GetTotalMutipleInput("");

            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedResult2, actualResult2);
        }

        [Fact]
        public void TestGetSumOfFibEvenNumber()
        {
            // Arrange
            ulong expectedResult = 10;

            // Act
            ulong actualResult = mobidiagAppViewModel.GetSumOfFibEvenNumber("5");

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetFibSumIput()
        {
            // Arrange
            ulong expectedResult = 1;
            ulong expectedResult2 = 4_000_000;

            // Act
            ulong actualResult = mobidiagAppViewModel.GetFibSumIput("1");
            ulong actualResult2 = mobidiagAppViewModel.GetFibSumIput("");

            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedResult2, actualResult2);
        }

        [Fact]
        public void TestGetLargestPrime()
        {
            ulong expectedResult = 5;
            ulong expectedResult2 = 6_008_514_751_43;

            //Act
            ulong acutalResult = mobidiagAppViewModel.GetPrimeInput("5");
            ulong acutalResult2 = mobidiagAppViewModel.GetPrimeInput("");

            // Assert
            Assert.Equal(expectedResult, acutalResult);
            Assert.Equal(expectedResult2, acutalResult2);
        }

        [Fact]
        public void TestGetPrimeInput()
        {
            // Arrange
            ulong expectedResult = 5;
            ulong expectedResult2 = 6_008_514_751_43;

            // Act
            ulong actualResult = mobidiagAppViewModel.GetPrimeInput("5");
            ulong acutalResult2 = mobidiagAppViewModel.GetPrimeInput("");

            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedResult2, acutalResult2);
        }
    }
}
