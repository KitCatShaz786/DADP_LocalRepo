using UnityEngine;

public class InvisibilityPotion : Potion
{

    void BecomeInvisible()
    {
        Debug.Log("Those around you are unaware of your presence. Invisibility!");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Drink();
        BecomeInvisible();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
