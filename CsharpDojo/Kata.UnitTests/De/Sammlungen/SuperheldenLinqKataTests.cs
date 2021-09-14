using BanallyMe.CSharpDojo.De.Sammlungen;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace BanallyMe.CSharpDojo.UnitTests.De.Sammlungen
{
    public class SuperheldenLinqKataTests
    {
        [Fact]
        public void GetErsteZwanzigNamen_GibtKorrekteNamenZurueck()
        {
            var erwarteteNamen = new[]
            {
                "Barry \"Flash\" Allen",
                "Bruce \"Hulk\" Banner",
                "Clint \"Hawkeye\" Barton",
                "Edward \"The Comedian\" Blake",
                "Arthur \"Aquaman\" Curry",
                "Carol \"Captain Marvel\" Danvers",
                "Ben \"Thing\" Grimm",
                "James \"Wolverine\" Howlett",
                "Hal \"Green Lantern\" Jordan",
                "Laurie \"Silk Spectre\" Juspeczyk",
                "Clark \"Superman\" Kent",
                "Walter \"Rorschach\" Kovacs",
                "Selina \"Catwoman\" Kyle",
                "Pietro \"Quicksilver\" Maximoff",
                "Wanda \"Scarlet Witch\" Maximoff",
                "Matt \"Daredevil\" Murdock",
                "Elektra \"Elektra\" Natchios",
                "Jon \"Doctor Manhattan\" Osterman",
                "Peter \"Spiderman\" Parker",
                "Diana \"Wonder Woman\" Prince"
            };

            var gefundeneNamen = SuperheldenLinqKata.GetErsteZwanzigNamen(superhelden);

            gefundeneNamen.Should().BeEquivalentTo(erwarteteNamen);
        }

        private static readonly IEnumerable<Superheld> superhelden = new []
        {
            new Superheld { Vorname = "Clark",   Nachname = "Kent",      HeldenName = "Superman" },
            new Superheld { Vorname = "Bruce",   Nachname = "Wayne",     HeldenName = "Batman" },
            new Superheld { Vorname = "Tony",    Nachname = "Stark",     HeldenName = "Iron Man" },
            new Superheld { Vorname = "Peter",   Nachname = "Parker",    HeldenName = "Spiderman" },
            new Superheld { Vorname = "Barry",   Nachname = "Allen",     HeldenName = "Flash" },
            new Superheld { Vorname = "Diana",   Nachname = "Prince",    HeldenName = "Wonder Woman" },
            new Superheld { Vorname = "Charles", Nachname = "Xavier",    HeldenName = "Professor X" },
            new Superheld { Vorname = "Bruce",   Nachname = "Banner",    HeldenName = "Hulk" },
            new Superheld { Vorname = "Arthur",  Nachname = "Curry",     HeldenName = "Aquaman" },
            new Superheld { Vorname = "Hal",     Nachname = "Jordan",    HeldenName = "Green Lantern" },
            new Superheld { Vorname = "Natasha", Nachname = "Romanoff",  HeldenName = "Black Widow" },
            new Superheld { Vorname = "Carol",   Nachname = "Danvers",   HeldenName = "Captain Marvel" },
            new Superheld { Vorname = "Clint",   Nachname = "Barton",    HeldenName = "Hawkeye" },
            new Superheld { Vorname = "Hank",    Nachname = "Pym",       HeldenName = "Ant-Man" },
            new Superheld { Vorname = "Janet",   Nachname = "van Dyne",  HeldenName = "Wasp" },
            new Superheld { Vorname = "Wanda",   Nachname = "Maximoff",  HeldenName = "Scarlet Witch" },
            new Superheld { Vorname = "Pietro",  Nachname = "Maximoff",  HeldenName = "Quicksilver" },
            new Superheld { Vorname = "James",   Nachname = "Howlett",   HeldenName = "Wolverine" },
            new Superheld { Vorname = "Ben",     Nachname = "Grimm",     HeldenName = "Thing" },
            new Superheld { Vorname = "Reed",    Nachname = "Richards",  HeldenName = "Mr. Fantastic" },
            new Superheld { Vorname = "Johnny",  Nachname = "Storm",     HeldenName = "Human Torch" },
            new Superheld { Vorname = "Susan",   Nachname = "Storm",     HeldenName = "Invisible Woman" },
            new Superheld { Vorname = "Selina",  Nachname = "Kyle",      HeldenName = "Catwoman" },
            new Superheld { Vorname = "Elektra", Nachname = "Natchios",  HeldenName = "Elektra" },
            new Superheld { Vorname = "Edward",  Nachname = "Blake",     HeldenName = "The Comedian" },
            new Superheld { Vorname = "Walter",  Nachname = "Kovacs",    HeldenName = "Rorschach" },
            new Superheld { Vorname = "Jon",     Nachname = "Osterman",  HeldenName = "Doctor Manhattan" },
            new Superheld { Vorname = "Laurie",  Nachname = "Juspeczyk", HeldenName = "Silk Spectre" },
            new Superheld { Vorname = "Stephen", Nachname = "Strange",   HeldenName = "Doctor Strange" },
            new Superheld { Vorname = "Wade",    Nachname = "Wilson",    HeldenName = "Deadpool" },
            new Superheld { Vorname = "Matt",    Nachname = "Murdock",   HeldenName = "Daredevil" },
        };
    }
}
