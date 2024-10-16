using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class UpdateMessageTest : MonoBehaviour
{
    private float preFrameTime = 0f;
    // Update : 매 프레임의 가장 처음 호출
    private void Update()
    {
        print($"Update 호출됨. 호출시간 : {Time.time}, 이전 프레임과의 시간 차이 : {Time.time - preFrameTime}");
        preFrameTime = Time.time;
    }
    // FixedUpdate : 게임 로직상 프레임과 별개로 물리연산이 수행될 때마다 호출. 호출 주기가 일정함.
    private void FixedUpdate()
    {
        
    }

    private float preFrameLateTime = 0f;

    // LateUpdate : 매 프레임의 가장 나중에 호출. 동일 프레임에서 호출되므로 Update와 호출 순서는 다르지만 시간 차이는 크지 않음.
    private void LateUpdate()
    {
        print($"LateUpdate 호출됨. 호출시간 : {Time.time}, 이전 프레임과의 시간 차이 : {Time.time - preFrameLateTime}");
        preFrameLateTime = Time.time;
    }
}
