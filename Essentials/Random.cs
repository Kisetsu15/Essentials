using UnityEngine;
using System.Collections.Generic;

namespace Essentials {
    /// <summary>
    /// Provides utility methods for generating random values.
    /// </summary>
    public static class Rand {
        // Static instance of System.Random to avoid repeated instantiation.
        private static readonly System.Random _random = new();

        /// <summary>
        /// Returns a random element from the provided list.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="list">The list from which to select a random element.</param>
        /// <returns>A randomly selected element from the list.</returns>
        /// <exception cref="System.ArgumentException">Thrown when the list is null or empty.</exception>
        public static T GetRandom<T>(List<T> list) {
            if (list == null || list.Count == 0) {
                throw new System.ArgumentException("The list cannot be null or empty", nameof(list));
            }
            return list[_random.Next(list.Count)];
        }
    }
}

