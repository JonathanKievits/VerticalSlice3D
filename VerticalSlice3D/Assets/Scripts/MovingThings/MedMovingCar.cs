﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedMovingCar : MonoBehaviour {

    private float _speed;

    private void Start()
    {
        _speed = 20f;
    }

    private void FixedUpdate()
    {
        this.transform.Translate(Vector3.back * _speed * Time.deltaTime);
    }
}
