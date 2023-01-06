using Solutions;

namespace Tests
{
    public class BreakCamelCaseTest
    {

        public BreakCamelCaseTest()
        {

        }

        [Fact]
        public void Test_ShouldReturnEmptyValue()
        {
            string response = BreakCamelCase.Solution("");

            Assert.Equal(String.Empty, response);
        }

        [Fact]
        public void Test_ShouldReturnStringWithNoSpaces()
        {
            string response = BreakCamelCase.Solution("sasybaka");

            Assert.Equal("sasybaka", response);
        }

        [Fact]
        public void Test_ShouldReturnStringWithEmptySpaces()
        {
            string response = BreakCamelCase.Solution("estoEsCamelCase");

            Assert.Equal("esto Es Camel Case", response);
        }
    }
}