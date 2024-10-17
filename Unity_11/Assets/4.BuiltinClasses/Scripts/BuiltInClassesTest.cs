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
        //Debug.Log($"Log{1}");
        //Debug.LogWarning("Log");
        //Debug.LogError("Log");
        //Debug.LogFormat("{0}, {1}", 3, 5.0);

        // Mathf : 유니티엔진에서 제공하는 다양한 수학 연산 함수가 포함된 클래스.

        //float a = -0.3f;
        //a = Mathf.Abs(a);

    }


    void Update()
    {
        //transform.position = transform.position + new Vector3(3, 2, 1) * Time.deltaTime;
        transform.Translate(new Vector3(3, 2, 1) * Time.deltaTime);
        transform.Rotate(new Vector3(30,20,10) * Time.deltaTime);
    }
}
