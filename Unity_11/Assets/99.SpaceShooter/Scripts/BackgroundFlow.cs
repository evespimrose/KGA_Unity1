using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{
    public class BackgroundFlow : MonoBehaviour
    {
        public float flowSpeed;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.down * flowSpeed * Time.deltaTime);

            if (transform.position.y < -2.55f)
                transform.position = Vector3.zero;
        }
    }
}