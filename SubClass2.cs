using UnityEngine;

public class SubClass2 : MotherClass
{

    public int CurrentStack;
    

    public override void DisplayItems()
    {
        base.DisplayItems();
        Debug.Log($"CurrentStack: {CurrentStack} ");
    }




}
