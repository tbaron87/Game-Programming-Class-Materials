using System.Collections.Generic;
using UnityEngine;

public class ForEachExample : MonoBehaviour
{
    [SerializeField]
    private List<InterfaceExample> examples;
    public void Start()
    {
        foreach(InterfaceExample example in examples)
        {
            example.increaseThreatLevel();
        }
    }
}

