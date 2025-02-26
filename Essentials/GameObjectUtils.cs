using UnityEngine;

namespace Essentials {
    public static class GameObjectUtils {

        /// <summary>
        /// Hides the specified GameObject by setting its active state to false.
        /// </summary>
        /// <param name="obj">The GameObject to hide.</param>
        public static void Hide(this GameObject obj) {
            Preconditions.CheckNotNull(obj, "GameObject is null");
            obj.SetActive(false);
        }

        /// <summary>
        /// Shows the specified GameObject by setting its active state to true.
        /// </summary>
        /// <param name="obj">The GameObject to show.</param>
        public static void Show(this GameObject obj) {
            Preconditions.CheckNotNull(obj, "GameObject is null");
            obj.SetActive(true);
        }

        /// <summary>
        /// Hides the GameObject associated with the specified Transform by setting its active state to false.
        /// </summary>
        /// <param name="transform">The Transform whose GameObject to hide.</param>
        public static void Hide(this Transform transform) {
            Preconditions.CheckNotNull(transform, "Transform is null");
            transform.gameObject.Hide();
        }

        /// <summary>
        /// Shows the GameObject associated with the specified Transform by setting its active state to true.
        /// </summary>
        /// <param name="transform">The Transform whose GameObject to show.</param>
        public static void Show(this Transform transform) {
            Preconditions.CheckNotNull(transform, "Transform is null");
            transform.gameObject.Show();
        }

        /// <summary>
        /// Checks if the specified GameObject has a component of type T and outputs the component if found.
        /// </summary>
        /// <typeparam name="T">The type of component to check for.</typeparam>
        /// <param name="obj">The GameObject to check.</param>
        /// <param name="component">The component if found, otherwise null.</param>
        /// <returns>True if the component is found, otherwise false.</returns>
        public static bool HasComponent<T>(this GameObject obj, out T component) {
            Preconditions.CheckNotNull(obj, "GameObject is null");
            component = obj.GetComponent<T>();
            return component != null;
        }

        /// <summary>
        /// Checks if the specified GameObject has a component of type T.
        /// </summary>
        /// <typeparam name="T">The type of component to check for.</typeparam>
        /// <param name="obj">The GameObject to check.</param>
        /// <returns>True if the component is found, otherwise false.</returns>
        public static bool HasComponent<T>(this GameObject obj) {
            return obj.HasComponent<T>(out _);
        }

        /// <summary>
        /// Checks if the GameObject associated with the specified Transform has a component of type T and outputs the component if found.
        /// </summary>
        /// <typeparam name="T">The type of component to check for.</typeparam>
        /// <param name="transform">The Transform whose GameObject to check.</param>
        /// <param name="component">The component if found, otherwise null.</param>
        /// <returns>True if the component is found, otherwise false.</returns>
        public static bool HasComponent<T>(this Transform transform, out T component) {
            return transform.gameObject.HasComponent<T>(out component);
        }

        /// <summary>
        /// Checks if the GameObject associated with the specified Transform has a component of type T.
        /// </summary>
        /// <typeparam name="T">The type of component to check for.</typeparam>
        /// <param name="transform">The Transform whose GameObject to check.</param>
        /// <returns>True if the component is found, otherwise false.</returns>
        public static bool HasComponent<T>(this Transform transform) {
            return transform.gameObject.HasComponent<T>();
        }
    }
}