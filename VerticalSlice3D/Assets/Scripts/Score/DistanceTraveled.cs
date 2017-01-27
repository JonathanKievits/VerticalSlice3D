using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTraveled : MonoBehaviour {

    [HideInInspector]public float distance = 0;

    private PlayerMovement playerMovement;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W) && playerMovement.pressed == false || Input.GetKeyDown(KeyCode.UpArrow) && playerMovement.pressed == false)
        {
            distance += 1;
        }

         if (Input.GetKeyDown(KeyCode.S) && playerMovement.pressed == false || Input.GetKeyDown(KeyCode.DownArrow) && playerMovement.pressed == false)
        {
            distance -= 1;
        }
    }
}
