using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMessageTest : MonoBehaviour
{

    /*
    Collider ������Ʈ�� isTrigger �Ӽ��� True�� ������ ������ 
    �������� �浹�� ����Ű�� �ʴ� ��� Collider ���� ���� �ٸ� Collider�� ��ȣ�ۿ� ����.
    OnCollistionXx �޽��� �Լ��� ���������� �� ��ü�� �ϳ��� rigidbody ������Ʈ�� �־�� ��.
    Trigger �޽��� �Լ��� �浹 ������ �������� �����Ƿ� ���� ȿ������.
    */
    private void OnTriggerEnter(Collider other)
    {
        Collider otherCollider = other;

        print($"Ʈ���ſ� ����. ȣ�� ��ü : {name}, �浹 ��� : {otherCollider.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        Collider otherCollider = other;

        print($"Ʈ���ſ��� ���. ȣ�� ��ü : {name}, �浹 ��� : {otherCollider.name}");
    }

    private void OnTriggerStay(Collider other)
    {
        Collider otherCollider = other;

        print($"Ʈ���ſ� ü����. ȣ�� ��ü : {name}, �浹 ��� : {otherCollider.name}");
    }
}
