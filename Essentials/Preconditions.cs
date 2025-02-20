using UnityEngine;

namespace Essentials {
    public static class Preconditions {
        /// <summary>
        /// Checks if a UnityEngine.Object is null or destroyed and throws an exception if it is.
        /// </summary>
        /// <param name="obj">The object to check.</param>
        /// <param name="message">The message for the exception if null.</param>
        public static void CheckNotNull (Object obj, string message) {
            if (obj == null) {
                throw new System.NullReferenceException(message);
            }
        }

        /// <summary>
        /// Checks if a UnityEngine.Object is not null or destroyed.
        /// </summary>
        /// <param name="obj">The object to check.</param>
        /// <returns>Returns true if the object is not null, otherwise false.</returns>
        public static bool IsNotNull (Object obj) {
            return obj == null;
        }
    }
}