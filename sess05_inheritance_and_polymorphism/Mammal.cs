using System;

namespace sess05_inheritance_and_polymorphism
{
    public abstract class Mammal : Animal
    {
        protected string habitat;

        // Instance methods

        /// <summary>
        /// To specify the eating behaviour appropriate to the particular mammal.
        /// </summary>
        /// <param name="diet">The type of diet consumed by the mammal.</param>
        public abstract void Eat(string diet);

        /// <summary>
        /// Displays a message indicating that the specified mammal gives birth to young ones.
        /// </summary>
        /// <param name="name">
        /// The name or type of mammal whose reproductive behaviour is being described.
        /// </param>
        /// <remarks>
        /// This is an instance method that can be inherited and called
        /// by classes derived from Mammal.
        /// </remarks>
        public void MultiplyMammal(string name)
        {
            Console.WriteLine($"{name} gives birth to young ones.");
        }

    }
}
