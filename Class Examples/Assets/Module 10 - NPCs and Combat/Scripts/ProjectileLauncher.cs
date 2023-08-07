using System.Collections;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;
    [SerializeField]
    private Transform launchPoint;
    [SerializeField]
    private float cooldownTime;
    private bool onCooldown = false;

    void Update()
    {
        if (!onCooldown && Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(projectilePrefab, launchPoint.position, launchPoint.rotation);
            onCooldown = true;
            StartCoroutine(cooldown());
        }
    }

    private IEnumerator cooldown()
    {
        yield return new WaitForSeconds(cooldownTime);
        onCooldown = false;
    }
}
