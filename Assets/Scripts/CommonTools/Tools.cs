using UnityEngine;
using System.Collections;
using System;

public static class Tools{

    static public T AddMissingComponent<T>(this GameObject go) where T : Component
    {
#if UNITY_FLASH
		object comp = go.GetComponent<T>();
#else
        T comp = go.GetComponent<T>();
#endif
        if (comp == null)
        {
            comp = go.AddComponent<T>();
        }
#if UNITY_FLASH
		return (T)comp;
#else
        return comp;
#endif
    }

    internal static IEnumerator Wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }
}
