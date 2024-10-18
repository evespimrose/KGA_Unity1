using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    MeshRenderer mr;

    public Material woodMaterial;

    private Material stoneMaterial;
    public Material redMaterial;
    public float intervalue = 3.0f;


    public Transform TransformTest;

    private Coroutine MaterialChangeCoroutine;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
        stoneMaterial = mr.material;
    }

    void Start()
    {
        // ��Ȯ�� 3�� �Ŀ� MeshRenderer�� Material�� woodMaterial�� ��ü�ϰ����.
        MaterialChangeCoroutine = StartCoroutine(MaterialChange(redMaterial, intervalue));

        //var enumerator = StringIEnumerator();
        //while (enumerator.MoveNext())
        //{
        //    print(enumerator.Current);
        //}

        //foreach (Transform t in TransformTest)
        //{
        //    print(t.name);
        //}

    }
    private IEnumerator MaterialChange(Material mat, float interval)
    {
        //while (true)
        //{
        //    yield return null;
        //    print("MaterialChange �ڷ�ƾ ȣ���");
        //}
        while (true)
        {
            yield return new WaitForSeconds(interval);
            mr.material = woodMaterial;
        }
    }
    private IEnumerator<string> StringIEnumerator()
    {
        yield return "a";
        yield return "b";
        yield return "c";
    }


    // Update is called once per frame
    void Update()
    {
        //if (Time.time > 3)
        //{
        //    mr.material = woodMaterial;
        //}

        if (Input.GetButtonDown("Jump"))
        {
            mr.material = stoneMaterial;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("�ڷ�ƾ ��ž");
            //StopCoroutine("MaterialChange");

            StopCoroutine(MaterialChangeCoroutine);
        }
    }
}
