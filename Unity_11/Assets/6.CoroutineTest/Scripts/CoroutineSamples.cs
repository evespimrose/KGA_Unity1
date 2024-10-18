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

        // StartCoroutine�� ȣ���ϸ� �ڷ�ƾ�� �ڵ鸵�ϴ� ��ü�� �� �ڽ��� �ǹǷ� �� ���� ������Ʈ�� ��Ȱ��ȭ �ǰų� Coroutine�� ���� Component�� ��Ȱ��ȭ �Ǹ� ��� Coroutine�� ������ ����.
    }




    private IEnumerator ReturnNull()
    {
        print("ReturnNull �ڷ�ƾ�� ���۵�");
        while (true)
        {
            yield return null;
            print($"ReturnNull �ڷ�ƾ�� ����� {Time.time}");

        }

    }

    private IEnumerator ReturnWaitForSeconds(float interval, int count)
    {
        print("ReturnWaitForSeconds �ڷ�ƾ�� ���۵�");
        for(int i = 0; i < count; i++) 
        {
            yield return new WaitForSeconds(interval);
            print($"ReturnWaitForSeconds �ڷ�ƾ�� {i + 1} �� ����� {Time.time}");

        }
        print("ReturnWaitForSeconds �ڷ�ƾ�� ����");

    }

    // WaitForSeconds�� ������ ������ TimeScale�� ������ ���� �ʴ´�.
    private IEnumerator ReturnWaitForSecondsRealTime(float interval, int count)
    {
        print("ReturnWaitForSecondsRealTime �ڷ�ƾ�� ���۵�");
        for (int i = 0; i < count; i++)
        {
            yield return new WaitForSecondsRealtime(interval);
            print($"ReturnWaitForSecondsRealTime �ڷ�ƾ�� {i + 1} �� ����� {Time.time}");

        }
        print("ReturnWaitForSecondsRealTime �ڷ�ƾ�� ����");

    }


    public bool continueKey;

    private bool IsContinue()
    {
        return continueKey;
    }
    //yeild return new WaitUntil / waitwhile : Ư�� ������ True / False�� �� ������ ���
    private IEnumerator ReturnWaitUntilWhile()
    {
        print("ReturnWaitUntilWhile �ڷ�ƾ�� ���۵�");

        while (true)
        {
            // new WaitUntil : �Ű������� �Ѿ �Լ�(�븮��)�� return�� False �� ���� ���, True ��� �Ѿ
            yield return new WaitUntil(() => continueKey);
            print($"��Ƽ�� Ű�� ���� {Time.time}");

            // new WaitWhile : �Ű������� �Ѿ �Լ�(�븮��)�� return�� True �� ���� ���, False ��� �Ѿ
            yield return new WaitWhile(IsContinue);
            print($"��Ƽ�� Ű�� ������ {Time.time}");

        }
        


    }
    //yeild return new ~Frame : �� ������ Ư�� Frame�ڿ� �����.
    private IEnumerator ReturnWaitForEndOfFrame()
    {
        // EndOfFrame : �ش� ������ ���� ���������� ��ٸ�
        yield return new WaitForEndOfFrame();

    }

    private IEnumerator ReturnWaitForFixedUpdate()
    {
        // FixedUpdate : ���������� ���� ������ ��ٸ�
        yield return new WaitForFixedUpdate();

    }

    private void Update()
    {

    }
}
