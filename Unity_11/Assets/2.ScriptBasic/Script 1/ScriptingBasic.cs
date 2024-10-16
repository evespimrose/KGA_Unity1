using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptingBasic : MonoBehaviour
{
    /*
     ������ ���۵Ǳ� ���� ������ ������ �� �ִ� ������Ʈ�� Inpector���� �Ҵ��Ͽ� ������ �� ����.
    �׷��� ������ ���۵Ǳ� ���� ������ �� ���ų�, Inpector���� ���� �Ҵ��� �� ���� ��ü��?
     */
    public GameObject target;

    private GameObject privateTarget;

    private GameObject findTarget;

    private GameObject newTarget;

    private GameObject namedNewTarget;

    private GameObject componentAttachedTarget;





    void Start()
    {
        /*
        privateTarget�� ã�´�.
        1. ��ü ������ �̸����� Ÿ���� ã�´�.
        �� ����� ���� ������Ʈ�� �������� ���ϰ� ũ�� �ɸ�
        ���� �̸��� ������Ʈ�� ���� �� ���� ��� � ������Ʈ�� Ž�� ���� Ȯ���� �� ����
        �̷� ������ Start() �Լ������� ���������� ����.
        */ 
        privateTarget = GameObject.Find("privateTarget");
        //print(privateTarget.name);

        /*
        2. ��ü ������ Ư�� ������Ʈ�� ������ �ִ� ��ü�� ã�´�.
        */

        //findTarget = (FindObjectOfType(typeof(FindMe)) as Component).gameObject;
        findTarget = FindObjectOfType<FindMe>().gameObject;

        /*
        3. �ƿ� ��ü�� ���� �����ϰ� �ش� ��ü�� ������ �����ص� �ȴ�.

        */

        newTarget = new GameObject();
        namedNewTarget = new GameObject("New GameObject");

        componentAttachedTarget = new GameObject("Component Attached Target", typeof(FindMe), typeof(SpriteRenderer));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
