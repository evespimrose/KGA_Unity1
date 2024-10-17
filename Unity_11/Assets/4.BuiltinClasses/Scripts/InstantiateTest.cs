using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    public GameObject original;
    private void Start()
    {
        // 이런거 없이도 딸깍 쌉가능
        //GameObject clone = new GameObject("Clone");

        //MeshFilter meshFilter = clone.AddComponent<MeshFilter>();
        //MeshRenderer meshRenderer = clone.AddComponent<MeshRenderer>();

        //meshFilter.mesh = original.GetComponent<MeshFilter>().mesh;
        //meshRenderer.material = original.GetComponent<MeshRenderer>().material;

        //clone.transform.position = original.transform.position + Vector3.right;

        //Instantiate(original).transform.position = original.transform.position + Vector3.right;

        // 복사와 동시에 Hieracy 상에서 특정 객체의 자식이 되어야 할 경우

        //Instantiate(original, transform);
        // 복사와 동시에 특정 위치에 특정 각도값으로 생성되어야 할 경우
        //Instantiate(original,Vector3.right, Quaternion.identity);

        // Instantiate함수는 파라미터를 통해 복제된 객체를 return함

        GameObject clone = Instantiate(original,Vector3.right, Quaternion.identity);
        clone.name = "this is clone";

        clone.GetComponent<MeshRenderer>().material.color = Color.gray;



    }

    private void Update()
    {
        
    }
}
