using UnityEngine;

public class SingletonExample
{
    private static SingletonExample instance = null;

    private string playerName;
    private int playerMoney;
    private bool newGamePlus;

    public static SingletonExample getInstance()
    {
        if(instance is null)
        {
            instance = new SingletonExample();
        }
        return instance;
    }

    private SingletonExample()
    {
        playerName = "Billy";
        playerMoney = 0;
        newGamePlus = false;
    }

    public void dummy()
    {
        Debug.Log(playerName + " " + playerMoney + " " + newGamePlus);
    }

}
