using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _space;

    private void Start ()
    {
        _space = 2.5f;
	}


    private void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _space);
        }else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * _space);
        }else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.back * _space);
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * _space);
        } 
	}
}

