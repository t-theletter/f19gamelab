﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMove : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * 5f * Time.deltaTime);

        if (transform.position.y <= 15)
        {
            Destroy(this.gameObject);

        }
    }
}
