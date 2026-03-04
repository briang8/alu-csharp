using System;

namespace Enemies
{
    /// <summary>
    /// Represents a zombie enemy in the game
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// The health points of the zombie
        /// </summary>
        private int health;
        /// <summary>
        /// The name of the zombie
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Initializes a new instance of the Zombie class with default health of 0
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Zombie class with specified health value
        /// </summary>
        /// <param name="value">The initial health value for the zombie. Must be greater than or equal to 0</param>
        /// <exception cref="ArgumentException">Thrown when health value is less than 0</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /// <summary>
        /// Gets or sets the name of the zombie
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Returns the current health of the zombie
        /// </summary>
        /// <returns>The current health value</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}