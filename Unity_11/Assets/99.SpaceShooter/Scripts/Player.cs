using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{
    public class Player : MonoBehaviour
    {

        public float moveSpeed = 2f;

        public float boundaryMinSize = -3.4f;
        public float boundaryMaxSize = 3.4f;

        public GameObject gameOverMessage;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            transform.Translate(new Vector3(x, y) * Time.deltaTime * moveSpeed);

            if (transform.position.x > boundaryMaxSize)
                transform.position = new Vector3(boundaryMaxSize, transform.position.y);

            else if (transform.position.x < boundaryMinSize)
                transform.position = new Vector3(boundaryMinSize, transform.position.y);

            if (transform.position.y > boundaryMaxSize)
                transform.position = new Vector3(transform.position.x, boundaryMaxSize);

            else if (transform.position.y < boundaryMinSize)
                transform.position = new Vector3(transform.position.x, boundaryMinSize);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
                GameOver();
        }

        public void GameOver()
        {
            gameOverMessage.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
