using System.Collections.Generic;
using UnityEngine;

public class SimpleWalk : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> waypoints;
    [SerializeField]
    private float speed;
    private int index = 0;

    public void Update()
    {
        transform.LookAt(waypoints[index].transform);
        transform.Translate(new Vector3(0, 0, speed));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Waypoint"))
        {
            index = (index + 1) % waypoints.Count;
        }
    }
}
