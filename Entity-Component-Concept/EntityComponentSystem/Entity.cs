using EntityComponentSystem.Components;
using System;

namespace EntityComponentSystem.Base
{
    /**
     * This inteface is used to assure correct usage of entities
     */

    /// <summary>
    /// Represents an Entity with manageable Components
    /// </summary>
    public interface Entity
    {
        /// <summary>
        /// Adds a component to the Entity
        /// </summary>
        /// <param name="component">Component to add</param>
        void AddComponent(Component component);

        /// <summary>
        /// Removes a component from the Entity
        /// </summary>
        /// <param name="component">Component to remove</param>
        void RemoveComponent(Component component);

        /// <summary>
        /// Checks if Entity has the searched component
        /// </summary>
        /// <param name="component">Component to search for</param>
        /// <returns>Returns <c>true</c> if Entity contains the searched Component, otherwise false</returns>
        bool HasComponent(Component component);

        /// <summary>
        /// Returns Component instances of a specified type
        /// </summary>
        /// <param name="componentType">Type of the searched Component</param>
        /// <returns></returns>
		Component[] GetComponentsOfType(Type componentType);
    }
}
