using UnityEngine;

public class GunShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject muzzelFlashPrefab;
    [SerializeField]
    private GameObject bulletHolePrefab;
    [SerializeField]
    private Transform muzzle;

    public void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(muzzelFlashPrefab, muzzle);
            RaycastHit hit;
            if(Physics.Raycast(muzzle.position, muzzle.forward, out hit))
            {
                if (hit.collider.gameObject.tag.Equals("Enemy"))
                {
                    Debug.Log("I've been shot!");
                }
                else if (hit.collider.gameObject.tag.Equals("Wall"))
                {
                    Instantiate(bulletHolePrefab, hit.point, Quaternion.identity);
                }
            }
        }
    }
}
