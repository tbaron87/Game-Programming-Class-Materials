using UnityEngine;

public class SimpleChase : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float speed;
    private bool chasing = false;

    private void Update()
    {
        if (!chasing)
        {
            transform.Rotate(new Vector3(0, speed, 0));
        }
        else
        {
            transform.LookAt(player.transform);
            transform.Translate(new Vector3(0, 0, speed));
        }
    }

    public void startChase()
    {
        chasing = true;
    }
}
