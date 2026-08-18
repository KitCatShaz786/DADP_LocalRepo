using UnityEngine;

public class Warrior : Character
{
        public string Weapon;
        

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Character char = gameObject.AddComponent<Character>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Warrior(string weapon) : base(char.name)
    {
        Weapon = weapon;
    }
}
