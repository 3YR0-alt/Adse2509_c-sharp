using System;

/// <summary>
/// Defines behaviour of a terrestrial animal.
/// </summary>
namespace sess06_abstract_classes_and_interfaces
{
    public interface ITerrestrialAnimal
    {
        /// <summary>
        /// Represents the action of eating performed by the terrestrial animal.
        /// </summary>
        /// <returns>A string describing the eating action.</returns>
        public string Eat();
    }
}
