using UnityEngine;

public class WeaponSwing : MonoBehaviour
{
    private float speed = 1.0f;
    private float stopAngle = 90.0f;

    public void Start()
    {
        transform.Rotate(new Vector3(0, -stopAngle, 0));
    }

    public void Update()
    {
        float yRotation = transform.localEulerAngles.y;
        if ((stopAngle - 1 < yRotation) && (stopAngle + 1 > yRotation))
        {
            Destroy(gameObject);
        }
        else
        {
            transform.Rotate(new Vector3(0, speed, 0));
        }
    }
}
