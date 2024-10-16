using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMessageTest : MonoBehaviour
{
    // 물리적인 충돌 또는 상호작용에 의해서 호출되는 메시지

    // 1. OnCollisionEnter : 물리적인 충돌이 일어났을 때 호출
    /*
     OnCollisionxx 메시지 호출 조건 : 호출 될 컴포넌트에 Collider 객체가 있어야 됨.
    메시지 함수를 호출하는 객체가 Rigidbody이므로, 충돌한 두 오브젝트 중 하나에는 꼭 Rigidbody가 붙어있어야 호출됨.
     */
    private void OnCollisionEnter(Collision collision)
    {
        Collider otherCollider = collision.collider;

        print($"충돌이 일어남. 호출 주체 : {name}, 충돌 대상 : {otherCollider.name}");
    }

    private void OnCollisionExit(Collision collision)
    {
        Collider otherCollider = collision.collider;

        print($"충돌이 종료됨.. 호출 주체 : {name}, 충돌 대상 : {otherCollider.name}");
    }

    private void OnCollisionStay(Collision collision)
    {
        Collider otherCollider = collision.collider;

        print($"충돌 지속중. 호출 주체 : {name}, 충돌 대상 : {otherCollider.name}");
    }
}
