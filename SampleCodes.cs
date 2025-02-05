using UnityEngine;

public class SampleCodes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private string newObjName;
    private TestCodes testCodes;
    private string newObjNameContainer;

    private SubClass1 class1;
    private SubClass2 class2;

    private AbstractionImplementation abstraction;

    #region Encapsulation
    //private void Start()
    //{

    //    testCodes = GetComponent<TestCodes>();
    //    testCodes.ObjectName = newObjName;
    //    testCodes.DisplayObjectName();
    //    GetObjectName();

    //}


    //private void GetObjectName()
    //{
    //    newObjNameContainer = testCodes.ObjectName;
    //    Debug.Log("Displaying newObjectNameContainer value, newObjectNameContainer: " + newObjNameContainer);
    //}

    #endregion

    #region Inheritance
    //private void Start()
    //{
    //    class1 = gameObject.AddComponent<SubClass1>();
    //    class1.ItemName = "Clock";
    //    class1.ItemDescription = "To Tell Time";
    //    class1.ItemType = "Key Item";
    //    class1.MaxStack = 10;
    //    class1.DisplayItems();

    //    class2 = gameObject.AddComponent<SubClass2>();
    //    class2.ItemName = "Watch";
    //    class2.ItemDescription = "To Tell Time and day";
    //    class2.ItemType = "Key Item";
    //    class2.MaxStack = 20;
    //    class2.CurrentStack = 3;
    //    class2.DisplayItems();



    //}

    #endregion

    #region Abstraction

    private void Start()
    {
        abstraction = gameObject.AddComponent<AbstractionImplementation>();
        abstraction.ItemName = "Stick";


    }
    #endregion

}

//[System.Serializable]
//public class Student
//{
//    public string name;
//    public int age;
//}