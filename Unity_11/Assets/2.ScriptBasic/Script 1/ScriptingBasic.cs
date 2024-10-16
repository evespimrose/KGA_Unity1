using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptingBasic : MonoBehaviour
{
    /*
     게임이 시작되기 전에 씬에서 참조할 수 있는 오브젝트는 Inpector에서 할당하여 참조할 수 있음.
    그런데 게임이 시작되기 전에 참조할 수 없거나, Inpector에서 값을 할당할 수 없는 객체는?
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
        privateTarget를 찾는다.
        1. 전체 씬에서 이름으로 타겟을 찾는다.
        이 방법은 씬에 오브젝트가 많을수록 부하가 크게 걸림
        같은 이름의 오브젝트가 여러 개 있을 경우 어떤 오브젝트가 탐색 될지 확신할 수 없음
        이런 이유로 Start() 함수에서만 제한적으로 쓰임.
        */ 
        privateTarget = GameObject.Find("privateTarget");
        //print(privateTarget.name);

        /*
        2. 전체 씬에서 특정 컴포넌트를 가지고 있는 객체를 찾는다.
        */

        //findTarget = (FindObjectOfType(typeof(FindMe)) as Component).gameObject;
        findTarget = FindObjectOfType<FindMe>().gameObject;

        /*
        3. 아예 객체를 직접 생성하고 해당 객체의 참조를 유지해도 된다.

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
