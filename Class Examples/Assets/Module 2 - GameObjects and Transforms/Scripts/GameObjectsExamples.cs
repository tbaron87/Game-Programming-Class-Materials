using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // Not used, just serves as an example

public class GameObjectsExamples : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    // This was an empty script made as a quick example
    private ExampleComponent exampleComponent;

    private const string METHOD_NAME = "SetActive";
    private const bool PARAMETER_NAME = false;

    public void Start()
    {
        if (player is null)
        {
            player = GameObject.Find("Player");
        }
        player.SendMessage(METHOD_NAME, PARAMETER_NAME,
        SendMessageOptions.DontRequireReceiver);
        exampleComponent = player.GetComponent<ExampleComponent>();
    }
}
