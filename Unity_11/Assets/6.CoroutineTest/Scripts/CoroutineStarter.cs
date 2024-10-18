using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineStarter : MonoBehaviour
{
    public CoroutineTarget target;
    private Coroutine coroutine_DamageOnTime;
    void Start()
    {
        target.StartCoroutine(DamageOnTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DamageOnTime()
    {
        print($"{name}이 {target.name}에게 도트 데미지를 주었음");

        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1f);

            print($"{target.name} : 아야! X {i}");
        }
    }
}
