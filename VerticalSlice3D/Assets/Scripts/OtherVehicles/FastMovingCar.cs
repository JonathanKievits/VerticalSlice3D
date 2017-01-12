﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastMovingCar : MonoBehaviour {

    private float speed;

    void Start()
    {
        speed = 20f;
    }

    void FixedUpdate()
    {
        this.transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
