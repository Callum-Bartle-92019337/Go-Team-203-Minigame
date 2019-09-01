/*
 * Singleton script from the asset store
 *
 */
using UnityEngine;

namespace Assets.Scripts
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {

        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance != null) { return _instance; }
                _instance = FindObjectOfType<T>();
                if (_instance != null) { return _instance; }
                GameObject singleton = new GameObject(typeof(T).Name);
                _instance = singleton.AddComponent<T>();
                return _instance;
            }
        }

    }
}
