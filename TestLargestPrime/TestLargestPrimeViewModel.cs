using LargestPrime.ViewModel;
using System;
using Xunit;

namespace TestLargestPrime
{
    public class TestLargestPrimeViewModel
    {
        [Fact]
        public void TestGetLargestPrime()
        {
            // Arrange
            LargestPrimeViewModel largestPrimeViewModel = new LargestPrimeViewModel();
            ulong expectedRsult = 1;
            ulong expectedRsult2 = 6857;

            // Act
            ulong actualResult = largestPrimeViewModel.GetLargestPrime(1);
            ulong actualResult2 = largestPrimeViewModel.GetLargestPrime(600851475143);

            // Assert
            Assert.Equal(expectedRsult, actualResult);
            Assert.Equal(expectedRsult2, actualResult2);
        }
    }
}
