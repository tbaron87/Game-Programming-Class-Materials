using UnityEngine;

public class VectorExamples : MonoBehaviour
{
    [SerializeField]
    private Vector3 example1;

    public void Start()
    {
        // This just serves to show all the different ways you can change Vectors
        example1 = new Vector3(0.0f, 0.0f, 0.0f);
        example1.x = 1.0f;
        example1.Set(1.0f, 1.0f, 1.0f);
        Vector3 example2 = Vector3.zero;
        transform.Translate(new Vector3(5.0f, 0.0f, 1.0f));
    }

}
