using UnityEngine;
//using Unity.Netcode;
//using UnityEngine.Networking;

/**
 * Unfortunately, UnityEngine.Networking has been depricatred and removed
 * since this was made for the class. Instead, you are now supposed to use
 * Netcode for GameObjects to do multiplayer. This is left for record
 * keeping, but will not work if commented back in.
 */
public class PlayerScript : MonoBehaviour // NetworkBehaviour
{
    /*
    // Demonstrates use of NetworkVariable for type INT
    private NetworkVariable<int> randomNumber = new NetworkVariable<int>(1,NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    [SerializeField] private Transform spawnedObject;
    private Transform spawnedObjectTransform;

    public override void OnNetworkSpawn()
    {
        randomNumber.OnValueChanged += (int previousValue, int newValue) =>
          {
              Debug.Log(OwnerClientId + ": The Random Number is " + randomNumber.Value);
          };
    }

    private void Update()
    {

        if (!IsOwner)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            //randomNumber.Value = Random.Range(0, 50);
            sampleServerRpc();
            sampleClientRpc();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Transform spawnedObjectTransform= Instantiate(spawnedObject);
            spawnedObjectTransform.GetComponent<NetworkObject>().Spawn(true);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (spawnedObjectTransform != null)
            {
                //spawnedObjectTransform.Despawn(true);
                Destroy(spawnedObjectTransform.gameObject);
            }

        }

        Vector3 moveDir = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) moveDir.z = +1f;
        if (Input.GetKey(KeyCode.S)) moveDir.z = -1f;
        if (Input.GetKey(KeyCode.A)) moveDir.x = -1f;
        if (Input.GetKey(KeyCode.D)) moveDir.x = +1f;

        float moveSpeed = 3f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }

    [ServerRpc]
    private void sampleServerRpc()
    {
        Debug.Log("Checking sample ServerRpc"+OwnerClientId);
    }

    // They need to be called from server
    [ClientRpc]
    private void sampleClientRpc()
    {
        Debug.Log("Checking sample ClientRpc");
    }
    */
}
