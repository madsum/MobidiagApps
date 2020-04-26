using EvenFibonacci.ViewModel;
using Xunit;

namespace TestEvenFibonacci
{
    public class TestEvenFibonacciViewModel
    {
        [Fact]
        public void TestSumOfFibEvenNumber()
        {
            // Arrange
            EvenFibonacciViewModel evenFibonacciViewModel
                = new EvenFibonacciViewModel();
            ulong expectResult = 10;

            // Act
            ulong actualResult = evenFibonacciViewModel.SumOfFibEvenNumber(5);

            //Assert
            Assert.Equal(expectResult, actualResult);
        }
    }
}
