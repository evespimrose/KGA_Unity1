using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySpaceShooter
{
    public class Player : MonoBehaviour
    {

        public float moveSpeed = 5f;

        public float boundaryMinSize = -4.5f;
        public float boundaryMaxSize = 4.5f;

        public GameObject gameOverMessage;
        private Rigidbody2D rb;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            rb.MovePosition(rb.position + (new Vector2(x, y) * Time.deltaTime * moveSpeed));
            //transform.Translate(new Vector3(x, y) * Time.deltaTime * moveSpeed);

            //if (transform.position.x > boundaryMaxSize)
            //    transform.position = new Vector3(boundaryMaxSize, transform.position.y);

            //else if (transform.position.x < boundaryMinSize)
            //    transform.position = new Vector3(boundaryMinSize, transform.position.y);

            //if (transform.position.y > boundaryMaxSize)
            //    transform.position = new Vector3(transform.position.x, boundaryMaxSize);

            //else if (transform.position.y < boundaryMinSize)
            //    transform.position = new Vector3(transform.position.x, boundaryMinSize);


        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            //if (collision.CompareTag("Enemy"))
            //    GameOver();
        }

        public void GameOver()
        {
            gameOverMessage.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
