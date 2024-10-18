using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float jumpPower = 5.0f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // 점프
        /*
        inputManager를 통한 입력 제어를 하려 할 경우
        모든 입력 처리는 update에서 이루어지기 때문에
        FixedUpdate에서는 정확한 계산이 어려움.
        */


        rb.MovePosition(rb.position + (new Vector3(x,0,z) * Time.deltaTime * moveSpeed));

        if (Input.GetButtonDown("Jump"))
        {
            //rb.velocity = Vector3.up * jumpPower;

            rb.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);
        }
        // 물리연산이 일어나는 시점에서 Update에서 이동한 위치와 간섭이 일어나면 다음 프레임의 값이 Rigidbody에 의해 변함.
        //transform.Translate(new Vector3(x,0,z) * Time.deltaTime * moveSpeed);
    }

    //private void FixedUpdate()
    //{

    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
            rb.AddForce(Vector3.back * 10f);
    }
}
