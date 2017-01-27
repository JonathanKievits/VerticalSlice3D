using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{

    private float score = 0;
    private DistanceTraveled distanceTraveled;
    

    [SerializeField]
    private Text scoreText;
    
	void Start ()
	{
	    distanceTraveled = GetComponent<DistanceTraveled>();
	}
	
	void Update ()
    {
        scoreText.text = score.ToString();
        if (Input.GetKeyDown(KeyCode.W) && distanceTraveled.distance == score || Input.GetKeyDown(KeyCode.UpArrow) && distanceTraveled.distance == score)
        {   
                score++;
        }
     }
}


    

