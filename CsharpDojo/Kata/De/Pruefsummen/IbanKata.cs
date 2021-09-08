using System;

namespace BanallyMe.CSharpDojo.De.Pruefsummen
{
    /// <summary>
    /// In diesem Kata soll eine International Bank Account Number (IBAN) erzeugt werden.
    /// </summary>
    /// <remarks>Skills: Grundwissen, Zeichenketten, Zahlen</remarks>
    public class IbanKata
    {
        /// <summary>
        /// Diese Funktion soll eine IBAN für einen zweistelligen Ländercode (ISO 3166-2) und eine basic bank account number erzeugen. 
        /// </summary>
        /// <param name="landIso3166">Ländercode des Landes, in dem das Konto registriert ist.</param>
        /// <param name="bban">Die Basic Bank Account Number für das Konto, dessen IBAN erzeugt werden soll.</param>
        /// <returns>Die IBAN für das übergebene Konto.</returns>
        /// <remarks>
        /// Das Erzeugen der IBAN erfolgt in diesen Schritten:
        /// <list type="number">
        /// <item>Es wird die Position jedes Buchstabens des Ländercodes im lateinischen Alphabet ermittelt.</item>
        /// <item>Zu jeder Position wird 9 addiert => Ein A ergäbe die Nummer 10.</item>
        /// <item>Beide Ergebnisse werden hintereinander gehängt, so entsteht die vierstellige Ländernummer.</item>
        /// <item>An die Ländernummer werden zwei Nullen angehängt.</item>
        /// <item>Die Ländernummer wird hinten an die BBAN angehängt.</item>
        /// <item>Die Ländernummer wird durch 97 geteilt und der Rest dieser Division ermittelt.</item>
        /// <item>Ist der Rest kleiner als 10, wird eine 0 vor den Rest angefügt. Das Ergebnis ist die zweistellige Prüfziffer der IBAN.</item>
        /// <item>Die IBAN ist die Verbindung des Ländercodes, der Prüfziffer und der BBAN.</item>
        /// </list>
        /// </remarks>
        public static string IbanFuerLandAusBban(string landIso3166, string bban)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Dies soll eine IBAN für eine deutsche Bankleitzahl (BLZ) und eine Kontonummer erzeugen.
        /// </summary>
        /// <param name="bankleitzahl">Bankleitzahl der Bank, bei welcher das Konto geführt wird..</param>
        /// <param name="kontonummer">Kontonummer des Kontos, für welches die IBAN erzeugt werden soll.</param>
        /// <returns>Die IBAN für das übergebene Bankkonto.</returns>
        /// <remarks>
        /// Die IBAN wird folgendermaßen erzeugt:
        /// <list type="number">
        /// <item>Die Kontonummer wird bis zu einer Länge von zehn Zeichen von links mit Nullen aufgefüllt.</item>
        /// <item>Die achtstellige Bankleitzahl wird mit der zehnstelligen Kontonummer verbunden.</item>
        /// <item>Das Ergebnis ist die achtzehnstellige BBAN, welche an obige Funktion <see cref="IbanFuerLandAusBban(string, string)"/> übergeben werden kann.</item>
        /// </list>
        /// </remarks>
        public static string IbanDeutschland(string bankleitzahl, string kontonummer)
        {
            throw new NotImplementedException();
        }
    }
}
