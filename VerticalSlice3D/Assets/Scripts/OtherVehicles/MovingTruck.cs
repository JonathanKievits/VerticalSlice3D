using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTruck : MonoBehaviour {

    private float _speed;

    private void Start()
    {
        _speed = 10f;
    }

    private void FixedUpdate()
    {
        this.transform.Translate(Vector3.back * _speed * Time.deltaTime);
    }
}
