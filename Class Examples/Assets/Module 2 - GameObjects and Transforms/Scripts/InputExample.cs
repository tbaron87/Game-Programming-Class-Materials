using UnityEngine;

public class InputExample : MonoBehaviour
{

    public void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("The Player is pressing A!");
        }
    }
}
