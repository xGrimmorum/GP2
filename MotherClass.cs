using UnityEngine;

public class MotherClass : MonoBehaviour
{
    public string ItemName;
    public string ItemDescription;
    public string ItemType;
    public int MaxStack;

    public virtual void DisplayItems()
    {
        Debug.Log($"Item Name: {ItemName}");
        Debug.Log($"Item Description: {ItemDescription}");
        Debug.Log($"Item Type: {ItemType}");
        Debug.Log($"Item Max Stack:" + MaxStack);
    }

}
