using UnityEngine;

[CreateAssetMenu(fileName = "InventoryItem", menuName = "Scriptable Objects/Inventory Item")]
public class InventoryItem : ScriptableObject
{   
    public string itemName;
    public string description;
    public int value;
}
