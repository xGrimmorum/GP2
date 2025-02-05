using UnityEngine;

public class AbstractionImplementation : AbstractSample
{


    public override void UsedItem()
    {

        Debug.Log($"Item Name: {ItemName}");
        Debug.Log($"Item Description: {ItemDescription}");
        Debug.Log($"Current Stack : {CurrentStack}");
        Debug.Log($"Max Stack: {MaxStack}");

    }


}
