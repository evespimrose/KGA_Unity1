using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    private float accel = 0f;
    private Coroutine coroutine_Move;
    private Coroutine coroutine_Accel;
    private Coroutine coroutine_Reborn;
    public bool isReborn = false;

    void Start()
    {
        coroutine_Move = StartCoroutine(EnemyMove());
        coroutine_Accel = StartCoroutine(Accel());
        coroutine_Reborn = StartCoroutine(EnemyReborn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator EnemyReborn()
    {
        while (true)
        {
            
            yield return new WaitUntil(() => transform.position.y < -5.0f);
            Vector3 pos = transform.position;
            // y값을 10.0으로 재설정
            pos.y = Random.Range(10.0f, 16.0f);
            // x값을 0.5와 6.7 사이의 랜덤값으로 설정
            pos.x = Random.Range(-4f, 4f);
            transform.position = pos;

            moveSpeed = Random.Range(0.5f, 1.5f);

            isReborn = true;

        }
    }

    private IEnumerator EnemyMove()
    {
        while (true)
        {
            yield return null;
            transform.position = Vector2.MoveTowards(transform.position, transform.position + Vector3.down, moveSpeed * Time.deltaTime * accel);
        }
       
    }

        private IEnumerator Accel()
    {
        while (true)
        {
            yield return null;
            accel += Time.deltaTime;
        }
    }
}
