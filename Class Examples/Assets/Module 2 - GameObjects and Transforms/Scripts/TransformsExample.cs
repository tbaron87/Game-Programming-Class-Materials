using UnityEngine;

public class TransformsExample : MonoBehaviour
{
    [SerializeField]
    private GameObject centerPoint;
    [SerializeField]
    private GameObject moon;

    public void Start()
    {

    }

    public void Update()
    {
        centerPoint.transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f));
        moon.transform.LookAt(centerPoint.transform);
    }
}
