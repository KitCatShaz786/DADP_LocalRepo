using UnityEngine;

public class Cat : MonoBehaviour

{

    public string catName;
    public int age;

    void Meow()
    {
        Debug.Log(catName + " has something to say. The little cat meows with enthusiasm!");
    }
}
