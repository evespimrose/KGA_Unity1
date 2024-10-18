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

        // ����
        /*
        inputManager�� ���� �Է� ��� �Ϸ� �� ���
        ��� �Է� ó���� update���� �̷������ ������
        FixedUpdate������ ��Ȯ�� ����� �����.
        */


        rb.MovePosition(rb.position + (new Vector3(x,0,z) * Time.deltaTime * moveSpeed));

        if (Input.GetButtonDown("Jump"))
        {
            //rb.velocity = Vector3.up * jumpPower;

            rb.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);
        }
        // ���������� �Ͼ�� �������� Update���� �̵��� ��ġ�� ������ �Ͼ�� ���� �������� ���� Rigidbody�� ���� ����.
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
