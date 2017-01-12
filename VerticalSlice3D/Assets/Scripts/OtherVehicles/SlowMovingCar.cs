using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMovingCar : MonoBehaviour {

    private float speed;

    void Start()
    {
        speed = 10f;
    }

    void FixedUpdate()
    {
        this.transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
