using BanallyMe.CSharpDojo.En.CheckDigits;
using FluentAssertions;
using Xunit;

namespace BanallyMe.CSharpDojo.UnitTests.En.CheckDigits
{
    public class IbanKataTests
    {
        [Theory]
        [InlineData("DE", "700901001234567890", "DE08700901001234567890")]
        [InlineData("AT", "123451234567", "AT621234500001234567")]
        public void IbanForCountryFromBban_GeneratesCorrectIban(string countryCode, string bban, string correctIban)
        {
            var generatedIban = IbanKata.IbanForCountryFromBban(countryCode, bban);

            generatedIban.Should().Be(correctIban);
        }

        [Theory]
        [InlineData("70090100", "1234567890", "DE08700901001234567890")]
        [InlineData("37040044", "532013000", "DE89370400440532013000")]
        public void IbanGermany_GeneratesCorrectIban(string bankIdentifierNumber, string accountNumber, string correctIban)
        {
            var generatedIban = IbanKata.IbanGermany(bankIdentifierNumber, accountNumber);

            generatedIban.Should().Be(correctIban);
        }
    }
}
