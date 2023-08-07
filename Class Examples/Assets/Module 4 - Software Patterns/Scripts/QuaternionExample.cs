using UnityEngine;

public class QuaternionExample : MonoBehaviour
{
    [SerializeField]
    private Quaternion quaternion;

    public void Start()
    {
        quaternion.Set(0.0f, 90.0f, 0.0f, 1.0f);
        transform.rotation = quaternion;
        Vector3 understandableRoation = transform.eulerAngles;
        transform.Rotate(new Vector3(0.0f, 90.0f, 0.0f));
    }

}
