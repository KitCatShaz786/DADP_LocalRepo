using UnityEngine;

public class Action : MonoBehaviour
{
    Bow Elegy = gameObject.AddComponent<Bow>();

    Sword Harbringer = gameObject.AddComponent<Sword>();

    List<Weapon> Weapons = new List<Weapon> {Elegy, Harbringer};

    foreach (Weapon weapon in Weapons)
    {
        weapon.Attack();
    }
}
