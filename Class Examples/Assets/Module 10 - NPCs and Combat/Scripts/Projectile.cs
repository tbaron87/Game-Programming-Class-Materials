using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float force;
    private Rigidbody body;

    public void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddForce(transform.forward * force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            Debug.Log("Enemy Hit!");
        }
        else if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Player Hit!");
        }
        Destroy(gameObject);
    }
}
