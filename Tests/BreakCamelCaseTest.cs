using Solutions;

namespace Tests
{
    public class BreakCamelCaseTest
    {
        private BreakCamelCase _solution;

        public BreakCamelCaseTest()
        {
            _solution = new BreakCamelCase();
        }

        [Fact]
        public void Test_EmptyValue()
        {
            string response = _solution.Handle("");

            Assert.Equal(String.Empty, response);
        }

        [Fact]
        public void Test_ShouldReturnStringWithNoSpaces()
        {
            string response = _solution.Handle("sasybaka");

            Assert.Equal("sasybaka", response);
        }

        [Fact]
        public void Test_ShouldReturnStringWithEmptySpaces()
        {
            string response = _solution.Handle("estoEsCamelCase");

            Assert.Equal("esto Es Camel Case", response);
        }
    }
}