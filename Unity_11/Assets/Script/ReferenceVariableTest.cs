using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionVariableTest : MonoBehaviour
{
    public string[] stringArray;
    public List<string> stringList;
    public LinkedList<string> stringLList;
    public Queue<string> stringQueue;
    public Stack<string> stringStack;
    public Dictionary<string, string> stringDic;




    void Start()
    {
        //foreach (string str in stringList)
        //{
        //    stringQueue.Enqueue(str);
        //}
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
