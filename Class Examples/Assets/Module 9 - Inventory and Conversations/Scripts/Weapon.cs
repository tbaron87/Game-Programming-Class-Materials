using UnityEngine;

public class Weapon : Item
{
    protected int damage;
    protected DamageType damageType;

    public Weapon(float weight, string name, string description, Sprite icon, int damage, DamageType damageType) : base(weight, name, description, icon)
    {
        this.damage = damage;
        this.damageType = damageType;
    }
}
