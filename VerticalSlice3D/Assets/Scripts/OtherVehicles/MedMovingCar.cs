using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedMovingCar : MonoBehaviour {

    private float speed;

    void Start()
    {
        speed = 15f;
    }

    void FixedUpdate()
    {
        this.transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
