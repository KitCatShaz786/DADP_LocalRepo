using UnityEngine;

public class Potion : MonoBehaviour
{

    public string potionName;
    public int potency;
    public float volume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Drink()
    {
        Debug.Log("You drank a " + potionName + " with a potency of " + potency + ", and a volume of " + volume);
    }
}
