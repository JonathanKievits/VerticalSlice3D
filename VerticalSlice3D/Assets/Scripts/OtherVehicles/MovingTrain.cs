using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTrain : MonoBehaviour {

    private float speed;

    void Start()
    {
        speed = 100f;
    }

    void FixedUpdate()
    {
        this.transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
