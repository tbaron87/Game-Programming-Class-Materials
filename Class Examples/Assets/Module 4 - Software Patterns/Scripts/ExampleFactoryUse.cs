using UnityEngine;

public class ExampleFactoryUse : MonoBehaviour
{
    public void Start()
    {
        ExampleFactoryObject example = ExampleFactory.getExampleObject();
    }
}
