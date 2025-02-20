using UnityEngine;

namespace Essentials {
    /// <summary>
    /// A class that represents a timer with optional looping functionality.
    /// </summary>
    public class Timer {
        private bool running = false;
        private float endTime;
        private float duration;
        private bool loopEnabled;

        /// <summary>
        /// Sets the timer with a specified duration and loop option.
        /// </summary>
        /// <param name="duration">The duration for the timer in seconds.</param>
        /// <param name="loop">If true, the timer will restart after reaching the end.</param>
        /// <returns>Returns true if the timer has reached the end, otherwise false.</returns>
        public bool SetTimer(float duration, bool loop) {
            if (!running) {
                this.duration = duration;
                loopEnabled = loop;
                endTime = Time.time + duration;
                running = true;
            }

            if (running && Time.time >= endTime) {
                if (loopEnabled) {
                    endTime = Time.time + duration;
                } else {
                    running = false;    
                }
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gets the current time remaining on the timer.
        /// </summary>
        /// <returns>The time remaining in seconds.</returns>
        public float GetCurrentTime() {
            return (endTime - Time.time);
        }

        /// <summary>
        /// Gets the normalized time remaining on the timer.
        /// </summary>
        /// <returns>The normalized time remaining, where 1 is the full duration and 0 is the end.</returns>
        public float GetNormalizedTime() {
            return (endTime - Time.time) / duration;
        }

        /// <summary>
        /// Resets the timer, stopping it if it is not looped.
        /// </summary>
        public void ResetTimer() {
            running = false;
        }
    }
}

