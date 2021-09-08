using BanallyMe.CSharpDojo.De.Pruefsummen;
using FluentAssertions;
using Xunit;

namespace BanallyMe.CSharpDojo.UnitTests.De.Pruefsummen
{
    public class IbanKataTests
    {
        [Theory]
        [InlineData("DE", "700901001234567890", "DE08700901001234567890")]
        [InlineData("AT", "123451234567", "AT621234500001234567")]
        public void IbanFuerLandAusBban_ErzeugtKorrekteIban(string laenderCode, string bban, string korrekteIban)
        {
            var erzeugteIban = IbanKata.IbanFuerLandAusBban(laenderCode, bban);

            erzeugteIban.Should().Be(korrekteIban);
        }

        [Theory]
        [InlineData("70090100", "1234567890", "DE08700901001234567890")]
        [InlineData("37040044", "532013000", "DE89370400440532013000")]
        public void IbanDeutschland_ErzeugtKorrekteIban(string bankleitzahl, string kontonummer, string korrekteIban)
        {
            var erzeugteIban = IbanKata.IbanDeutschland(bankleitzahl, kontonummer);

            erzeugteIban.Should().Be(korrekteIban);
        }
    }
}
