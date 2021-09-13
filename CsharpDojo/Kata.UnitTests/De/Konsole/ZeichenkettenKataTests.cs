using BanallyMe.CSharpDojo.De.Konsole;
using FluentAssertions;
using System;
using System.IO;
using Xunit;

namespace BanallyMe.CSharpDojo.UnitTests.De.Konsole
{
    public class ZeichenkettenKataTests
    {
        private const string dojoDebugAusgabe = "Tisq\r\nTibsq\r\nTibsq.Epkp\r\nD.Tibsq.Epkp\r\nC-Sharp-Dojo\r\n";
        private const string dojoName = "C-Sharp-Dojo";

        [Fact]
        public void BuildDojoName_DokumentiertZwischenschritte()
        {
            using var konsoleAusgabe = new StringWriter();
            var originalAusgabe = Console.Out;
            Console.SetOut(konsoleAusgabe);

            ZeichenkettenKata.BuildDojoName();
            var erzeugterOutput = konsoleAusgabe.ToString();

            erzeugterOutput.Should().Be(dojoDebugAusgabe);

            Console.SetOut(originalAusgabe);
        }

        [Fact]
        public void BuildDojoName_GibtKorrektenNamenZurueck()
        {
            var erzeugterName = ZeichenkettenKata.BuildDojoName();

            erzeugterName.Should().Be(dojoName);
        }
    }
}
