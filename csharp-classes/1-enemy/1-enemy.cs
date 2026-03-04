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
        public int health;

        /// <summary>
        /// Initializes a new instance of the Zombie class with default health of 0
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
    }
}