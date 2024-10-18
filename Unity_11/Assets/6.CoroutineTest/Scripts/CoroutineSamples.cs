using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSamples : MonoBehaviour
{
    private Coroutine ReturnNullCoroutine;
    private Coroutine ReturnWaitForSecondsCoroutine;
    private Coroutine ReturnWaitForSecondsRealTimeCoroutine;
    private Coroutine ReturnWaitUntilWhileCoroutine;

    void Start()
    {
        //ReturnNullCoroutine = StartCoroutine(ReturnNull());
        //ReturnWaitForSecondsCoroutine = StartCoroutine(ReturnWaitForSeconds(1.0f, 5));
        //ReturnWaitForSecondsRealTimeCoroutine = StartCoroutine(ReturnWaitForSecondsRealTime(1.0f,10));
        //ReturnWaitUntilWhileCoroutine = StartCoroutine(ReturnWaitUntilWhile());

        // StartCoroutine을 호출하면 코루틴을 핸들링하는 객체가 나 자신이 되므로 내 게임 오브젝트가 비활성화 되거나 Coroutine을 가진 Component가 비활성화 되면 모든 Coroutine도 동작을 멈춤.
    }




    private IEnumerator ReturnNull()
    {
        print("ReturnNull 코루틴이 시작됨");
        while (true)
        {
            yield return null;
            print($"ReturnNull 코루틴이 수행됨 {Time.time}");

        }

    }

    private IEnumerator ReturnWaitForSeconds(float interval, int count)
    {
        print("ReturnWaitForSeconds 코루틴이 시작됨");
        for(int i = 0; i < count; i++) 
        {
            yield return new WaitForSeconds(interval);
            print($"ReturnWaitForSeconds 코루틴이 {i + 1} 번 수행됨 {Time.time}");

        }
        print("ReturnWaitForSeconds 코루틴이 끝남");

    }

    // WaitForSeconds와 동작은 같으나 TimeScale에 영향을 받지 않는다.
    private IEnumerator ReturnWaitForSecondsRealTime(float interval, int count)
    {
        print("ReturnWaitForSecondsRealTime 코루틴이 시작됨");
        for (int i = 0; i < count; i++)
        {
            yield return new WaitForSecondsRealtime(interval);
            print($"ReturnWaitForSecondsRealTime 코루틴이 {i + 1} 번 수행됨 {Time.time}");

        }
        print("ReturnWaitForSecondsRealTime 코루틴이 끝남");

    }


    public bool continueKey;

    private bool IsContinue()
    {
        return continueKey;
    }
    //yeild return new WaitUntil / waitwhile : 특정 조건이 True / False가 될 때까지 대기
    private IEnumerator ReturnWaitUntilWhile()
    {
        print("ReturnWaitUntilWhile 코루틴이 시작됨");

        while (true)
        {
            // new WaitUntil : 매개변수로 넘어간 함수(대리자)의 return이 False 인 동안 대기, True 라면 넘어감
            yield return new WaitUntil(() => continueKey);
            print($"컨티뉴 키가 참됨 {Time.time}");

            // new WaitWhile : 매개변수로 넘어간 함수(대리자)의 return이 True 인 동안 대기, False 라면 넘어감
            yield return new WaitWhile(IsContinue);
            print($"컨티뉴 키가 거짓됨 {Time.time}");

        }
        


    }
    //yeild return new ~Frame : 인 게임의 특정 Frame뒤에 수행됨.
    private IEnumerator ReturnWaitForEndOfFrame()
    {
        // EndOfFrame : 해당 프레임 가장 마지막까지 기다림
        yield return new WaitForEndOfFrame();

    }

    private IEnumerator ReturnWaitForFixedUpdate()
    {
        // FixedUpdate : 물리연산이 끝날 때까지 기다림
        yield return new WaitForFixedUpdate();

    }

    private void Update()
    {

    }
}
