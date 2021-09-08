using System;

namespace BanallyMe.CSharpDojo.En.CheckDigits
{
    /// <summary>
    /// This Kata contains building an International Bank Account Number (IBAN).
    /// </summary>
    /// <remarks>Skills: Basic Knowledge, Strings, Numbers</remarks>
    public class IbanKata
    {
        /// <summary>
        /// This should calculate an IBAN for a two-letter country code (ISO 3166-2) and a basic bank account number. 
        /// </summary>
        /// <param name="countryIso3166">Country Code for the country, in which the bank account has been registered.</param>
        /// <param name="bban">The Basic Bank Account Number for the account, whose IBAN should be generated.</param>
        /// <returns>The IBAN for the given bank account.</returns>
        /// <remarks>
        /// Building the IBAN includes the following steps:
        /// <list type="number">
        /// <item>The position for each letter of the country code in the latin alphabet is determined.</item>
        /// <item>Each of the two positions is added to the number 9 => A would result in the number 10.</item>
        /// <item>The two results are concatenated, resulting in a 4-digit-string, the country number.</item>
        /// <item>Two zeros are appended to this country number.</item>
        /// <item>The country number is appended to the BBAN.</item>
        /// <item>The remainder of the division by 97 of this result is determined.</item>
        /// <item>If the remainder is less than 10 a single zero gets prepended. The result ist the 2-digit-checksum of the IBAN.</item>
        /// <item>The IBAN is the concatenation of the two-letter country code, the checksum, and the BBAN.</item>
        /// </list>
        /// </remarks>
        public static string IbanForCountryFromBban(string countryIso3166, string bban)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This should generate an IBAN for a German bankIdentifierNumber (BLZ) and an Account number.
        /// </summary>
        /// <param name="bankIdentifierNumber">Unique number which identifies the bank that holds the account.</param>
        /// <param name="accountNumber">Account number of the account whose IBAN should be generated.</param>
        /// <returns>The IBAN for the given bank account.</returns>
        /// <remarks>
        /// Building the IBAN includes the following steps:
        /// <list type="number">
        /// <item>The account number is padded with zeros on the left side so it has a length of 10.</item>
        /// <item>The 8-digit bankIdentifierNumber is concatenated with the 10-digit account number.</item>
        /// <item>The result of the concentanation is the 18-digit BBAN which can be passed to the above function <see cref="IbanForCountryFromBban(string, string)"/></item>
        /// </list>
        /// </remarks>
        public static string IbanGermany(string bankIdentifierNumber, string accountNumber)
        {
            throw new NotImplementedException();
        }
    }
}
