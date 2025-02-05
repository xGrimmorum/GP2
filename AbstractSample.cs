using UnityEngine;

public abstract class AbstractSample : MonoBehaviour
{

    public string ItemName;
    public string ItemDescription;
    public int CurrentStack;
    public int MaxStack;


    public abstract void UsedItem();



}
