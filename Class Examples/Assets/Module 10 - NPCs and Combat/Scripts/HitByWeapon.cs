using UnityEngine;

public class HitByWeapon : MonoBehaviour
{
    private const string ENEMY_TAG = "Enemy";
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag.Equals(ENEMY_TAG))
        {
            Debug.Log("Ow!");
        }
    }
}
