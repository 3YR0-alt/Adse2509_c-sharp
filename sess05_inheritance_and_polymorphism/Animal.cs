using System;

namespace sess05_inheritance_and_polymorphism
{
    public abstract class Animal
    {
        /// <summary>
        /// Stores the type of food consumed by the animal.
        /// </summary>
        /// <remarks>
        /// This field is protected, allowing it to be accessed directly
        /// within the animal class and its derived classes.
        /// </remarks>
        protected string food;

        /// <summary>
        /// Stores the type of activity performed by the animal.
        /// </summary>
        /// <remarks>
        /// This field is protected, allowing it to be accessed directly
        /// within the Animal class and its derived classes.
        /// </remarks>
        protected string activity;
    }
}
