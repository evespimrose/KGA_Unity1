using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterMove : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody characterRigidbody;
    public float jumpForce = 5f;
    public int jumpCount = 15;
    public TextMeshProUGUI text;

    private void Jump()
    {
        print("jumpCount : " + jumpCount);
        characterRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //jumpCount--;
    }

    void Start()
    {
        characterRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        // -1 ~ 1

        float fallSpeed = characterRigidbody.velocity.y; // 떨어지는 속도 저장

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity *= speed;
        velocity.y = fallSpeed; // 떨어지는 속도 초기화
        characterRigidbody.velocity = velocity;


        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            Jump();
            //text.text = "jumpCount : " + jumpCount;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("floor"))
        {
            jumpCount = 5;
            //text.text = "jumpCount : " + jumpCount;
        }
    }
}
