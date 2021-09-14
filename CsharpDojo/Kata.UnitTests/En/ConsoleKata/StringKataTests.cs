using BanallyMe.CSharpDojo.En.ConsoleKata;
using FluentAssertions;
using System;
using System.IO;
using Xunit;

namespace BanallyMe.CSharpDojo.UnitTests.En.ConsoleKata
{
    [Collection("console")]
    public class StringKataTests
    {
        private const string dojoDebugOutput = "Tisq\r\nTibsq\r\nTibsq.Epkp\r\nD.Tibsq.Epkp\r\nC-Sharp-Dojo\r\n";
        private const string dojoName = "C-Sharp-Dojo";

        [Fact]
        public void BuildDojoName_PrintsIntermediateSteps()
        {
            using var consoleOutput = new StringWriter();
            var originalOutput = Console.Out;
            Console.SetOut(consoleOutput);

            StringKata.BuildDojoName();
            var generatedOutput = consoleOutput.ToString();

            generatedOutput.Should().Be(dojoDebugOutput);

            Console.SetOut(originalOutput);
        }

        [Fact]
        public void BuildDojoName_ReturnsCorrectName()
        {
            var createdName = StringKata.BuildDojoName();

            createdName.Should().Be(dojoName);
        }
    }
}
