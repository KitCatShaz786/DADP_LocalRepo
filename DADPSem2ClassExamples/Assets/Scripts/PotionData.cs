using UnityEngine;

[CreateAssetMenu(fileName = "PotionData", menuName = "Scriptable Objects/Potion Data")]
public class PotionData : ScriptableObject
{
    public string potionName;
    public int healAmount;
}
