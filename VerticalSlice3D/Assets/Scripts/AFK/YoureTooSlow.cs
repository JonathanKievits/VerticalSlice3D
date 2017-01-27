using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoureTooSlow : MonoBehaviour {

    private float _speed;

    private void Start()
    {
        _speed = 2.5f;
    }

    private void FixedUpdate()
    {
        this.transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
