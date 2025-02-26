using System.Collections.Generic;
using System.Text;

namespace Essentials {

    public static class CollectionExtensions {

        private static readonly System.Random _random = new();

        /// <summary>
        /// Converts the collection to a string representation with all elements.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="collection">The collection to convert to a string.</param>
        /// <returns>A string representation of the collection.</returns>
        public static string All<T>(this IEnumerable<T> collection) {
            if (collection == null) return "[ Null ]";

            StringBuilder result = new("[ ");
            bool first = true;

            foreach (var item in collection) {
                if (!first) result.Append(", ");
                result.Append(item);
                first = false;
            }

            result.Append(" ]");
            return result.ToString();
        }

        /// <summary>
        /// Returns a random element from the collection.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="collection">The collection to select a random element from.</param>
        /// <returns>A random element from the collection.</returns>
        /// <exception cref="System.ArgumentException">Thrown when the collection is null or empty.</exception>
        public static T Random<T>(this IEnumerable<T> collection) {
            List<T> list = new(collection);
            if (list == null || list.Count == 0) {
                throw new System.ArgumentException("The Collection cannot be null or empty", nameof(collection));
            }
            return list[_random.Next(list.Count)];
        }
    }
}