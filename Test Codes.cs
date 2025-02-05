using UnityEngine;

public class TestCodes : MonoBehaviour
{

    private string objectName;

    public string ObjectName
    {
        get 
        { 
            return objectName;
        }
        set 
        {
            objectName = value;
        }
    }

    public void DisplayObjectName()
    {
        Debug.Log("Displaying objectName value, objectName" + objectName);
    }

}
