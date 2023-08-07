using UnityEngine;

public class DontDestroyExample : MonoBehaviour
{
    private const string TAG = "Do Not Duplicate";
    public void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(TAG);

        if(objects.Length > 1)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
}
