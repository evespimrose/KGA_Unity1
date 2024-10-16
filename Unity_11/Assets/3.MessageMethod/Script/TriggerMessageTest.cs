using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMessageTest : MonoBehaviour
{

    /*
    Collider 컴포넌트의 isTrigger 속성을 True로 설정해 놓으면 
    물리적인 충돌을 일으키지 않는 대신 Collider 영역 내의 다른 Collider와 상호작용 가능.
    OnCollistionXx 메시지 함수와 마찬가지로 두 객체중 하나는 rigidbody 컴포넌트가 있어야 함.
    Trigger 메시지 함수는 충돌 정보를 생성하지 않으므로 비교적 효율적임.
    */
    private void OnTriggerEnter(Collider other)
    {
        Collider otherCollider = other;

        print($"트리거에 닿음. 호출 주체 : {name}, 충돌 대상 : {otherCollider.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        Collider otherCollider = other;

        print($"트리거에서 벗어남. 호출 주체 : {name}, 충돌 대상 : {otherCollider.name}");
    }

    private void OnTriggerStay(Collider other)
    {
        Collider otherCollider = other;

        print($"트리거에 체류중. 호출 주체 : {name}, 충돌 대상 : {otherCollider.name}");
    }
}
