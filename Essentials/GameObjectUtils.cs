using UnityEngine;

namespace Essentials {
    public static class GameObjectUtils {

        /// <summary>
        /// Hides the specified GameObject by setting its active state to false.
        /// </summary>
        /// <param name="obj">The GameObject to hide.</param>
        public static void Hide(GameObject obj) {
            Preconditions.CheckNotNull(obj, obj.name + " is null");
            obj.SetActive(false);
        }

        /// <summary>
        /// Shows the specified GameObject by setting its active state to true.
        /// </summary>
        /// <param name="obj">The GameObject to show.</param>
        public static void Show(GameObject obj) {
            Preconditions.CheckNotNull(obj, obj.name + " is null");
            obj.SetActive(true);
        }

        /// <summary>
        /// Hides the GameObject associated with the specified Transform by setting its active state to false.
        /// </summary>
        /// <param name="transform">The Transform whose GameObject to hide.</param>
        public static void Hide(Transform transform) {
            Preconditions.CheckNotNull(transform, transform.name + " is null");
            Hide(transform.gameObject);
        }

        /// <summary>
        /// Shows the GameObject associated with the specified Transform by setting its active state to true.
        /// </summary>
        /// <param name="transform">The Transform whose GameObject to show.</param>
        public static void Show(Transform transform) {
            Preconditions.CheckNotNull(transform, transform.name + " is null");
            Show(transform.gameObject);
        }

        /// <summary>
        /// Checks if the specified GameObject has a component of type T and outputs the component if found.
        /// </summary>
        /// <typeparam name="T">The type of component to check for.</typeparam>
        /// <param name="obj">The GameObject to check.</param>
        /// <param name="component">The component if found, otherwise null.</param>
        /// <returns>True if the component is found, otherwise false.</returns>
        public static bool HasComponent<T>(GameObject obj, out T component) {
            Preconditions.CheckNotNull(obj, obj.name + " is null");
            component = obj.GetComponent<T>();
            return component != null;
        }

        /// <summary>
        /// Checks if the specified GameObject has a component of type T.
        /// </summary>
        /// <typeparam name="T">The type of component to check for.</typeparam>
        /// <param name="obj">The GameObject to check.</param>
        /// <returns>True if the component is found, otherwise false.</returns>
        public static bool HasComponent<T>(GameObject obj) {
            return HasComponent<T>(obj, out _);
        }

        /// <summary>
        /// Checks if the GameObject associated with the specified Transform has a component of type T and outputs the component if found.
        /// </summary>
        /// <typeparam name="T">The type of component to check for.</typeparam>
        /// <param name="transform">The Transform whose GameObject to check.</param>
        /// <param name="component">The component if found, otherwise null.</param>
        /// <returns>True if the component is found, otherwise false.</returns>
        public static bool HasComponent<T>(Transform transform, out T component) {
            return HasComponent<T>(transform.gameObject, out component);
        }

        /// <summary>
        /// Checks if the GameObject associated with the specified Transform has a component of type T.
        /// </summary>
        /// <typeparam name="T">The type of component to check for.</typeparam>
        /// <param name="transform">The Transform whose GameObject to check.</param>
        /// <returns>True if the component is found, otherwise false.</returns>
        public static bool HasComponent<T>(Transform transform) {
            return HasComponent<T>(transform.gameObject);
        }
    }
}