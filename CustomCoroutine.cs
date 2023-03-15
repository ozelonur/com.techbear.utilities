using System;
using System.Collections;
using UnityEngine;

namespace TechBear.Utilities
{
    public static class CustomCoroutine
    {
        public static IEnumerator WaitForFrames(int count, Action callback = null)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new WaitForEndOfFrame();
            }

            callback?.Invoke();
        }
    }
}