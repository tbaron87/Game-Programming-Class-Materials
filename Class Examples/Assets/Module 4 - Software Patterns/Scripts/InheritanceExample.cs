using UnityEngine;

public abstract class InheritanceExample
{
    private int speed;

    public abstract void takeDamage();

    public void move(int newSpeed)
    {
        speed = newSpeed;
    }

    public void dummy()
    {
        Debug.Log(speed);
    }
}
