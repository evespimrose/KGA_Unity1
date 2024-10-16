using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class UpdateMessageTest : MonoBehaviour
{
    private float preFrameTime = 0f;
    // Update : �� �������� ���� ó�� ȣ��
    private void Update()
    {
        print($"Update ȣ���. ȣ��ð� : {Time.time}, ���� �����Ӱ��� �ð� ���� : {Time.time - preFrameTime}");
        preFrameTime = Time.time;
    }
    // FixedUpdate : ���� ������ �����Ӱ� ������ ���������� ����� ������ ȣ��. ȣ�� �ֱⰡ ������.
    private void FixedUpdate()
    {
        
    }

    private float preFrameLateTime = 0f;

    // LateUpdate : �� �������� ���� ���߿� ȣ��. ���� �����ӿ��� ȣ��ǹǷ� Update�� ȣ�� ������ �ٸ����� �ð� ���̴� ũ�� ����.
    private void LateUpdate()
    {
        print($"LateUpdate ȣ���. ȣ��ð� : {Time.time}, ���� �����Ӱ��� �ð� ���� : {Time.time - preFrameLateTime}");
        preFrameLateTime = Time.time;
    }
}
