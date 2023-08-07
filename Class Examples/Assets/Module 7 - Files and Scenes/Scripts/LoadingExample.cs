using System.IO;
using UnityEngine;

public class LoadingExample : MonoBehaviour
{
    private string path = "Assets/SaveGames/save.txt";
    public void Start()
    {
        StreamReader reader = new StreamReader(path);
        string json = reader.ReadToEnd();
        reader.Close();

        ExamplePlayerData examplePlayerData = JsonUtility.FromJson<ExamplePlayerData>(json);
        Debug.Log(examplePlayerData);
    }
}
