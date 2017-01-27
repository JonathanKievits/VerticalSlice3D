using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfTheWater : MonoBehaviour
{

    private float _right;
    private Vector3 curPos;
	void Start ()
	{
	    _right = 25f;
	    curPos = new Vector3(_right, 0, 0);
	}
	
	void Update ()
    {
        if (transform.position.x < -25f)
        {
            _right = 25f;
        }
	}
}
