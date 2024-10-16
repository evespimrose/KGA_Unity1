using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMessageTest : MonoBehaviour
{
    // �������� �浹 �Ǵ� ��ȣ�ۿ뿡 ���ؼ� ȣ��Ǵ� �޽���

    // 1. OnCollisionEnter : �������� �浹�� �Ͼ�� �� ȣ��
    /*
     OnCollisionxx �޽��� ȣ�� ���� : ȣ�� �� ������Ʈ�� Collider ��ü�� �־�� ��.
    �޽��� �Լ��� ȣ���ϴ� ��ü�� Rigidbody�̹Ƿ�, �浹�� �� ������Ʈ �� �ϳ����� �� Rigidbody�� �پ��־�� ȣ���.
     */
    private void OnCollisionEnter(Collision collision)
    {
        Collider otherCollider = collision.collider;

        print($"�浹�� �Ͼ. ȣ�� ��ü : {name}, �浹 ��� : {otherCollider.name}");
    }

    private void OnCollisionExit(Collision collision)
    {
        Collider otherCollider = collision.collider;

        print($"�浹�� �����.. ȣ�� ��ü : {name}, �浹 ��� : {otherCollider.name}");
    }

    private void OnCollisionStay(Collision collision)
    {
        Collider otherCollider = collision.collider;

        print($"�浹 ������. ȣ�� ��ü : {name}, �浹 ��� : {otherCollider.name}");
    }
}
