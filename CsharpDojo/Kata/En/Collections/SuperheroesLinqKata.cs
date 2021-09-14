using System;
using System.Collections.Generic;

namespace BanallyMe.CSharpDojo.En.Collections
{
    /// <summary>
    /// This Kata should train the usage of Linq using a collection of superheroes.
    /// </summary>
    public class SuperheroesLinqKata
    {
        /// <summary>
        /// This function should return the first twenty entries from a collection of superheroes.
        /// The superheroes should be ordered first by last name and then by first name before that.
        /// Returned names should have the following format: First name "Alter Ego" Last Name
        /// </summary>
        /// <param name="superheroes">Collection of superheroes that should be filtered.</param>
        /// <returns>Collection of the found superheroes.</returns>
        public static IEnumerable<string> GetFirstTwentyNames(IEnumerable<Superhero> superheroes)
            => throw new NotImplementedException();
    }

    /// <summary>
    /// Contains a superhero.
    /// </summary>
    public class Superhero
    {
        /// <summary>
        /// The first name of the superhero.
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// The last name of the superhero.
        /// </summary>
        public string LastName { get; set; } = "";

        /// <summary>
        /// The alter ego of the superhero.
        /// </summary>
        public string AlterEgo { get; set; } = "";
    }
}
