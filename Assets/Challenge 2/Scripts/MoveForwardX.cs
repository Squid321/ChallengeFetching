﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.x < -25 ) {
            Destroy(gameObject);
        }
        if (transform.position.y < -50) {
            Destroy(gameObject);
        }
    }
}
