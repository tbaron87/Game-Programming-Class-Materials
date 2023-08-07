using System.IO;
using UnityEngine;

public class SavingExample : MonoBehaviour
{
    public void Start()
    {
        ExamplePlayerData examplePlayerData = new ExamplePlayerData();
        examplePlayerData.level = 1;
        examplePlayerData.money = 0;
        examplePlayerData.accuracy = 0.5f;
        examplePlayerData.playerName = "Billy";
        examplePlayerData.finishedGame = false;

        string json = JsonUtility.ToJson(examplePlayerData);
        writeToFile(json);
    }

    private void writeToFile(string json)
    {
        string path = "Assets/SaveGames/save.txt";

        StreamWriter writer = new StreamWriter(path);
        writer.WriteLine(json);
        writer.Close();
    }

}
