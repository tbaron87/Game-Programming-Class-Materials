using System.Collections;
using UnityEngine;

public class MeleeSwing : MonoBehaviour
{
    [SerializeField]
    private GameObject weaponPrefab;
    private float weaponCooldown = 1.0f;
    private bool onCooldown = false;

    public void Update()
    {
        if(!onCooldown && Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(weaponPrefab, transform);
            onCooldown = true;
            StartCoroutine(cooldown());
        }
    }

    private IEnumerator cooldown()
    {
        yield return new WaitForSeconds(weaponCooldown);
        onCooldown = false;
    }
}
