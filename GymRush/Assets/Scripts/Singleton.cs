using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;

    public static T Instance
    {
        get 
        {
            if (_instance == null)
            {
                var objs = FindObjectOfType(typeof(T)) as T[];
                if (objs != null && objs.Length > 0) _instance = objs[0];
                if (_instance == null)
                {
                    GameObject obj = new GameObject(typeof(T).Name);
                    _instance = obj.AddComponent<T>();
                }
            }

            return _instance;
        }
    }
}
