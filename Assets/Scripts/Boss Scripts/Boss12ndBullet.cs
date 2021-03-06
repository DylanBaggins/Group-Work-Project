﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss12ndBullet : MonoBehaviour {

    float speed; //the bullets speed
    Vector2 _direction; //the direction of the bullet
    bool isReady; //to know when the bullet direction is set

    void Awake()
    {
        speed = 10f;
        isReady = false;

    }

    // Use this for initialization
    void Start()
    {

    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction.normalized;

        isReady = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isReady)
        {
            Vector2 position = transform.position;

            position += _direction * speed * Time.deltaTime;

            transform.position = position;

        }
    }
}
