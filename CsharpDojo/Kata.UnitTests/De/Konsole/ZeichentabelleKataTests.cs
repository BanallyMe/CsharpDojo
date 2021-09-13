using BanallyMe.CSharpDojo.De.Konsole;
using FluentAssertions;
using System;
using System.IO;
using Xunit;

namespace BanallyMe.CSharpDojo.UnitTests.De.Konsole
{
    public class ZeichentabelleKataTests
    {
        private const string zeichentabellenAusschnitt = "33 -- 00100001 -- 21 -- !\r\n"
            + "34 -- 00100010 -- 22 -- \"\r\n"
            + "35 -- 00100011 -- 23 -- #\r\n"
            + "36 -- 00100100 -- 24 -- $\r\n"
            + "37 -- 00100101 -- 25 -- %\r\n"
            + "38 -- 00100110 -- 26 -- &\r\n"
            + "39 -- 00100111 -- 27 -- '\r\n"
            + "40 -- 00101000 -- 28 -- (\r\n"
            + "41 -- 00101001 -- 29 -- )\r\n"
            + "42 -- 00101010 -- 2a -- *\r\n"
            + "43 -- 00101011 -- 2b -- +\r\n"
            + "44 -- 00101100 -- 2c -- ,\r\n"
            + "45 -- 00101101 -- 2d -- -\r\n"
            + "46 -- 00101110 -- 2e -- .\r\n"
            + "47 -- 00101111 -- 2f -- /\r\n"
            + "48 -- 00110000 -- 30 -- 0\r\n"
            + "49 -- 00110001 -- 31 -- 1\r\n"
            + "50 -- 00110010 -- 32 -- 2\r\n"
            + "51 -- 00110011 -- 33 -- 3\r\n"
            + "52 -- 00110100 -- 34 -- 4\r\n"
            + "53 -- 00110101 -- 35 -- 5\r\n"
            + "54 -- 00110110 -- 36 -- 6\r\n"
            + "55 -- 00110111 -- 37 -- 7\r\n"
            + "56 -- 00111000 -- 38 -- 8\r\n"
            + "57 -- 00111001 -- 39 -- 9\r\n"
            + "58 -- 00111010 -- 3a -- :\r\n"
            + "59 -- 00111011 -- 3b -- ;\r\n"
            + "60 -- 00111100 -- 3c -- <\r\n"
            + "61 -- 00111101 -- 3d -- =\r\n"
            + "62 -- 00111110 -- 3e -- >\r\n"
            + "63 -- 00111111 -- 3f -- ?\r\n"
            + "64 -- 01000000 -- 40 -- @\r\n";

        [Fact]
        public void DruckeZeichentabelle_ErzeugtKorrektenOutput()
        {
            
            using var konsoleAusgabe = new StringWriter();
            var originalAusgabe = Console.Out;
            Console.SetOut(konsoleAusgabe);

            ZeichentabelleKata.DruckeZeichentabelle();
            var erzeugterOutput = konsoleAusgabe.ToString();

            erzeugterOutput.Should().Be(zeichentabellenAusschnitt);

            Console.SetOut(originalAusgabe);
        }
    }
}
