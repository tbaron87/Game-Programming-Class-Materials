using System.Collections.Generic;
using UnityEngine;

public class SimpleSteal : MonoBehaviour
{
    [SerializeField]
    private List<SimpleChase> chaseList;
    [SerializeField]
    private float alertDistance;
    private bool playerInRange = false;
    private const string PLAYER_TAG = "Player";

    public void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            foreach(SimpleChase chase in chaseList)
            {
                if(Vector3.Distance(transform.position, chase.transform.position) < alertDistance)
                {
                    chase.startChase();
                }
                
            }
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(PLAYER_TAG))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals(PLAYER_TAG))
        {
            playerInRange = false;
        }
    }
}
