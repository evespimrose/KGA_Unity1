using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuiltInClassesTest : MonoBehaviour
{
    /*
    Debug : ����뿡 ����ϴ� ����� �����ϴ� Ŭ����

    */


    void Start()
    {
        Debug.Log($"Log{1}");
        Debug.LogWarning("Log");
        Debug.LogError("Log");
        Debug.LogFormat("{0}, {1}", 3, 5.0);

    }


    void Update()
    {
        
    }
}
