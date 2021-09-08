using BanallyMe.CSharpDojo.De.Konsole;
using FluentAssertions;
using System;
using System.IO;
using Xunit;

namespace BanallyMe.CSharpDojo.UnitTests.De.Konsole
{
    public class FizzBuzzKataTests
    {
        private const string dreiFuenfFizzBuzzAusgabe =
            "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n"
            + "11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n16\r\n17\r\nFizz\r\n19\r\nBuzz\r\n"
            + "Fizz\r\n22\r\n23\r\nFizz\r\nBuzz\r\n26\r\nFizz\r\n28\r\n29\r\nFizzBuzz\r\n"
            + "31\r\n32\r\nFizz\r\n34\r\nBuzz\r\nFizz\r\n37\r\n38\r\nFizz\r\nBuzz\r\n"
            + "41\r\nFizz\r\n43\r\n44\r\nFizzBuzz\r\n46\r\n47\r\nFizz\r\n49\r\nBuzz\r\n"
            + "Fizz\r\n52\r\n53\r\nFizz\r\nBuzz\r\n56\r\nFizz\r\n58\r\n59\r\nFizzBuzz\r\n"
            + "61\r\n62\r\nFizz\r\n64\r\nBuzz\r\nFizz\r\n67\r\n68\r\nFizz\r\nBuzz\r\n"
            + "71\r\nFizz\r\n73\r\n74\r\nFizzBuzz\r\n76\r\n77\r\nFizz\r\n79\r\nBuzz\r\n"
            + "Fizz\r\n82\r\n83\r\nFizz\r\nBuzz\r\n86\r\nFizz\r\n88\r\n89\r\nFizzBuzz\r\n"
            + "91\r\n92\r\nFizz\r\n94\r\nBuzz\r\nFizz\r\n97\r\n98\r\nFizz\r\nBuzz\r\n";

        [Fact]
        public void DreiFuenfFizzBuzz_ErzeugtKorrektenKonsolenOutput()
        {            
            using var konsoleAusgabe = new StringWriter();
            var originalAusgabe = Console.Out;
            Console.SetOut(konsoleAusgabe);

            FizzBuzzKata.DreiFuenfFizzBuzz();
            var erzeugterOutput = konsoleAusgabe.ToString();

            erzeugterOutput.Should().Be(dreiFuenfFizzBuzzAusgabe);

            Console.SetOut(originalAusgabe);
        }
    }
}
