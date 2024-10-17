using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuiltInClassesTest : MonoBehaviour
{
    /*
    Debug : 디버깅에 사용하는 기능을 제공하는 클래스

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
