using UnityEngine;

public class GameObjectDestructionExample : MonoBehaviour
{
    [SerializeField]
    private int limit;
    [SerializeField]
    private GameObject target;

    public void Update()
    {
        if (limit <= 0)
        {
            Destroy(target);
        }
    }
}
