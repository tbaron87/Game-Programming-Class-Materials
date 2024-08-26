using UnityEngine;
using UnityEngine.UI;
//using Unity.Netcode;

/**
 * This class has the same issue as the PlayerScript script
 * in this Multiplayer module. See that for details.
 */
public class NetworkManagerUI : MonoBehaviour
{
   
    
        [SerializeField] private Button serverButton;
        [SerializeField] private Button hostButton;
        [SerializeField] private Button clientButton;

    private void Awake()
    {
        serverButton.onClick.AddListener(() =>
        {
            //NetworkManager.Singleton.StartServer();
        });
        hostButton.onClick.AddListener(() =>
        {
            //NetworkManager.Singleton.StartHost();
        });
        clientButton.onClick.AddListener(() =>
        {
            //NetworkManager.Singleton.StartClient();
        });

    }


 
}
