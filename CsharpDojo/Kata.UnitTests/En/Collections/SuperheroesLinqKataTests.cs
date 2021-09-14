using BanallyMe.CSharpDojo.En.Collections;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace BanallyMe.CSharpDojo.UnitTests.En.Collections
{
    public class SuperheroesLinqKataTests
    {
        [Fact]
        public void GetFirstTwentyNames_ReturnsCorrectNames()
        {
            var expectedNames = new[]
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

            var foundNames = SuperheroesLinqKata.GetFirstTwentyNames(superheroes);

            foundNames.Should().BeEquivalentTo(expectedNames);
        }

        private static readonly IEnumerable<Superhero> superheroes = new[]
        {
            new Superhero { FirstName = "Clark",   LastName = "Kent",      AlterEgo = "Superman" },
            new Superhero { FirstName = "Bruce",   LastName = "Wayne",     AlterEgo = "Batman" },
            new Superhero { FirstName = "Tony",    LastName = "Stark",     AlterEgo = "Iron Man" },
            new Superhero { FirstName = "Peter",   LastName = "Parker",    AlterEgo = "Spiderman" },
            new Superhero { FirstName = "Barry",   LastName = "Allen",     AlterEgo = "Flash" },
            new Superhero { FirstName = "Diana",   LastName = "Prince",    AlterEgo = "Wonder Woman" },
            new Superhero { FirstName = "Charles", LastName = "Xavier",    AlterEgo = "Professor X" },
            new Superhero { FirstName = "Bruce",   LastName = "Banner",    AlterEgo = "Hulk" },
            new Superhero { FirstName = "Arthur",  LastName = "Curry",     AlterEgo = "Aquaman" },
            new Superhero { FirstName = "Hal",     LastName = "Jordan",    AlterEgo = "Green Lantern" },
            new Superhero { FirstName = "Natasha", LastName = "Romanoff",  AlterEgo = "Black Widow" },
            new Superhero { FirstName = "Carol",   LastName = "Danvers",   AlterEgo = "Captain Marvel" },
            new Superhero { FirstName = "Clint",   LastName = "Barton",    AlterEgo = "Hawkeye" },
            new Superhero { FirstName = "Hank",    LastName = "Pym",       AlterEgo = "Ant-Man" },
            new Superhero { FirstName = "Janet",   LastName = "van Dyne",  AlterEgo = "Wasp" },
            new Superhero { FirstName = "Wanda",   LastName = "Maximoff",  AlterEgo = "Scarlet Witch" },
            new Superhero { FirstName = "Pietro",  LastName = "Maximoff",  AlterEgo = "Quicksilver" },
            new Superhero { FirstName = "James",   LastName = "Howlett",   AlterEgo = "Wolverine" },
            new Superhero { FirstName = "Ben",     LastName = "Grimm",     AlterEgo = "Thing" },
            new Superhero { FirstName = "Reed",    LastName = "Richards",  AlterEgo = "Mr. Fantastic" },
            new Superhero { FirstName = "Johnny",  LastName = "Storm",     AlterEgo = "Human Torch" },
            new Superhero { FirstName = "Susan",   LastName = "Storm",     AlterEgo = "Invisible Woman" },
            new Superhero { FirstName = "Selina",  LastName = "Kyle",      AlterEgo = "Catwoman" },
            new Superhero { FirstName = "Elektra", LastName = "Natchios",  AlterEgo = "Elektra" },
            new Superhero { FirstName = "Edward",  LastName = "Blake",     AlterEgo = "The Comedian" },
            new Superhero { FirstName = "Walter",  LastName = "Kovacs",    AlterEgo = "Rorschach" },
            new Superhero { FirstName = "Jon",     LastName = "Osterman",  AlterEgo = "Doctor Manhattan" },
            new Superhero { FirstName = "Laurie",  LastName = "Juspeczyk", AlterEgo = "Silk Spectre" },
            new Superhero { FirstName = "Stephen", LastName = "Strange",   AlterEgo = "Doctor Strange" },
            new Superhero { FirstName = "Wade",    LastName = "Wilson",    AlterEgo = "Deadpool" },
            new Superhero { FirstName = "Matt",    LastName = "Murdock",   AlterEgo = "Daredevil" },
        };
    }
}
