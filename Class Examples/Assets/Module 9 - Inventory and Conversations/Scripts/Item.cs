using UnityEngine;

public class Item
{
    protected float weight;
    protected string name;
    protected string description;
    protected Sprite icon;

    public Item(float weight, string name, string description, Sprite icon)
    {
        this.weight = weight;
        this.name = name;
        this.description = description;
        this.icon = icon;
    }

    public float getWeight()
    {
        return weight;
    }

    public Sprite GetSprite()
    {
        return icon;
    }

    public string getName()
    {
        return name;
    }
}
