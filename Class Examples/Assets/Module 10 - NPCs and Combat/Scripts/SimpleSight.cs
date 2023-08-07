using UnityEngine;

public class SimpleSight : MonoBehaviour
{
    [SerializeField]
    private SimpleChase simpleChase;
    private const string PLAYER_TAG = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(PLAYER_TAG))
        {
            simpleChase.startChase();
        }
    }
}
