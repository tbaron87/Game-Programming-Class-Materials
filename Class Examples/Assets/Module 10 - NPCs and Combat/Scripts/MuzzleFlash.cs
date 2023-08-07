using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour
{
    
    private const float duration = 1f;
    private float speed = 0.1f;
    private bool growing = false;

    public void Start()
    {
        StartCoroutine(wait());
    }
    public void Update()
    {
        transform.localScale = transform.localScale * speed;
    }

    private void swap()
    {
        if (growing)
        {
            growing = false;
            speed *= -1;
            StartCoroutine(wait());
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(duration);
        swap();
    }
}
