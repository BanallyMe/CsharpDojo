using System;
using System.Collections.Generic;

namespace BanallyMe.CSharpDojo.De.Sammlungen
{
    /// <summary>
    /// Diese Kata soll anhand einer Sammlung von Superhelden den Umgang mit Linq trainieren.
    /// </summary>
    public class SuperheldenLinqKata
    {
        /// <summary>
        /// Diese Funktion soll die ersten zwanzig Superhelden aus einer Sammlung von Superhelden
        /// ausgeben. Zuvor sollen die Superhelden zunächst nach Nachnamen und dann nach Vornamen sortiert werden.
        /// Die Namen sollen in diesem Format zurückgegeben werden: Vorname "Heldenname" Nachname
        /// </summary>
        /// <param name="superhelden">Sammlung der Superhelden, die gefiltert werden soll.</param>
        /// <returns>Sammlung der gefundenen Superhelden.</returns>
        public static IEnumerable<string> GetErsteZwanzigNamen(IEnumerable<Superheld> superhelden)
            => throw new NotImplementedException();
    }

    /// <summary>
    /// Bildet einen Superhelden ab.
    /// </summary>
    public class Superheld
    {
        /// <summary>
        /// Der Vorname des Helden.
        /// </summary>
        public string Vorname { get; set; } = "";

        /// <summary>
        /// Der Nachname des Helden.
        /// </summary>
        public string Nachname { get; set; } = "";

        /// <summary>
        /// Der Heldenname des Helden.
        /// </summary>
        public string HeldenName { get; set; } = "";
    }
}
