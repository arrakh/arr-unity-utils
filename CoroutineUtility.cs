using System.Collections;
using UnityEngine;

namespace Arr.UnityUtils
{
    public static class CoroutineUtility
    {
        public class EmptyMonoBehaviour : MonoBehaviour {}
        
        static EmptyMonoBehaviour _instance;

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            if (_instance != null) return;
            GameObject go = new ("Coroutine Utility") {hideFlags = HideFlags.HideInInspector};
            _instance = go.AddComponent<EmptyMonoBehaviour>();
            go.hideFlags = HideFlags.HideInHierarchy;
            Object.DontDestroyOnLoad(go);
        }

        public static Coroutine Start(IEnumerator routine) => _instance.StartCoroutine(routine);
        public static void Stop(IEnumerator routine) => _instance.StopCoroutine(routine);
        public static void Stop(Coroutine routine) => _instance.StopCoroutine(routine);
    }
}