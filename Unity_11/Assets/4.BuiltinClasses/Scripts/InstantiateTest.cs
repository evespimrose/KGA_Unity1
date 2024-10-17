using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    public GameObject original;
    private void Start()
    {
        // �̷��� ���̵� ���� �԰���
        //GameObject clone = new GameObject("Clone");

        //MeshFilter meshFilter = clone.AddComponent<MeshFilter>();
        //MeshRenderer meshRenderer = clone.AddComponent<MeshRenderer>();

        //meshFilter.mesh = original.GetComponent<MeshFilter>().mesh;
        //meshRenderer.material = original.GetComponent<MeshRenderer>().material;

        //clone.transform.position = original.transform.position + Vector3.right;

        //Instantiate(original).transform.position = original.transform.position + Vector3.right;

        // ����� ���ÿ� Hieracy �󿡼� Ư�� ��ü�� �ڽ��� �Ǿ�� �� ���

        //Instantiate(original, transform);
        // ����� ���ÿ� Ư�� ��ġ�� Ư�� ���������� �����Ǿ�� �� ���
        //Instantiate(original,Vector3.right, Quaternion.identity);

        // Instantiate�Լ��� �Ķ���͸� ���� ������ ��ü�� return��

        GameObject clone = Instantiate(original,Vector3.right, Quaternion.identity);
        clone.name = "this is clone";

        clone.GetComponent<MeshRenderer>().material.color = Color.gray;



    }

    private void Update()
    {
        
    }
}
