using UnityEngine;

public class ClassThatImplementsTheExample : MonoBehaviour, InterfaceExample
{
    public bool getAlertedState()
    {
        throw new System.NotImplementedException();
    }

    public Transform getLocationPlayerWasLastSpottedAt()
    {
        throw new System.NotImplementedException();
    }

    public void increaseThreatLevel()
    {
        throw new System.NotImplementedException();
    }

}
