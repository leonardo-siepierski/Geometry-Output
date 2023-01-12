using FluentAssertions;
using Geometry_Output;

namespace GeometryOutput_Test
{
    public class GeometryOutputTestWithValidInputs
    {
        [Theory]
        [InlineData("C",
            "  A  \r\n" +
            " B B \r\n" +
            "C   C\r\n" +
            " B B \r\n" +
            "  A  ")]
        [InlineData("D",
            "   A   \r\n" +
            "  B B  \r\n" +
            " C   C \r\n" +
            "D     D\r\n" +
            " C   C \r\n" +
            "  B B  \r\n" +
            "   A   ")]
        public void Should_Return_Diamond_For_Input_C_Or_D(string userInput, string expectedOutput)
        {
            var consoleInput = new StringReader(userInput);
            Console.SetIn(consoleInput);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            GeometryOutput.AskForLetter();
            var output = consoleOutput.ToString();

            output.Should().Contain(expectedOutput);
        }
    }
}