using UnityEngine;

namespace YoukaiFox.UnityExtensions
{
    public static class AudioSourceExtensions 
    {
        // Author: Youkai Fox Studio
        /// <summary>
        /// Start playing even if it's already playing something.
        /// </summary>
        public static void PlayForced(this AudioSource self)
        {
            if (!self)
                return;

            if (self.isPlaying)
                self.Stop();

            self.Play();
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Start playing the <param name="clip"> even if it's already playing something.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="clip"></param>
        public static void PlayForced(this AudioSource self, AudioClip clip)
        {
            if (!self)
                return;

            if (self.isPlaying)
                self.Stop();
            
            self.clip = clip;
            self.Play();
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Turn loop on and play.
        /// </summary>
        public static void PlayLooped(this AudioSource self)
        {
            if (!self)
                return;

            self.loop = true;

            if (!self.isPlaying)
                self.Play();
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Turn loop on and play the provided AudioClip.
        /// </summary>
        public static void PlayLooped(this AudioSource self, AudioClip clip)
        {
            if (!self)
                return;

            self.loop = true;
            self.clip = clip;

            if (!self.isPlaying)
                self.Play();
        }
    }
}