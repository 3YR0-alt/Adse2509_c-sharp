using System;

/// <summary>
/// Defines behaviour of a marine animal.
/// </summary>
namespace sess06_abstract_classes_and_interfaces
{
    public interface IMarineAnimal
    {
        /// <summary>
        /// Represents the action of eating performed by the marine animal.
        /// </summary>
        /// <returns>A string describing the eating action.</returns>
        public string Eat();
    }
}
