using UnityEngine;

public class HealthPotion : Potion
{

    void RestoreHealth()
    {
        Debug.Log("You feel revitalized. Healed, even! Hooray!");
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Drink();
        RestoreHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
