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
        //Debug.Log($"Log{1}");
        //Debug.LogWarning("Log");
        //Debug.LogError("Log");
        //Debug.LogFormat("{0}, {1}", 3, 5.0);

        // Mathf : ����Ƽ�������� �����ϴ� �پ��� ���� ���� �Լ��� ���Ե� Ŭ����.

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
