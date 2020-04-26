using Multiples.ViewModel;
using System;
using Xunit;

namespace TestMultiples
{
    public class TestMultiplesViewModel
    {
        [Fact]
        public void TestGetMultiples()
        {
            //Arrange 
            MultiplesViewModel multiplesViewModel = new MultiplesViewModel();
            long expectedResult = 8;
            long expectedResult2 = 234168;

            //Act
            long acutalResult = multiplesViewModel.GetMultiples(5);
            long acutalResult2 = multiplesViewModel.GetMultiples(1000);

            // Assert
            Assert.Equal(expectedResult, acutalResult);
            Assert.Equal(expectedResult2, acutalResult2);
        }
    }
}
