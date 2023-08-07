using UnityEngine;

public class GameObjectCreationExample : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabToClone;

    public void Start()
    {
        if (prefabToClone is not null)
        {
            GameObject gameObject = Instantiate(prefabToClone);
        }
    }

}
