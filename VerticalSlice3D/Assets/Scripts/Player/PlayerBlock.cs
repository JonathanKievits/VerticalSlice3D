using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlock : MonoBehaviour
{

    private PlayerMovement pMove;

	void Start ()
	{
	    pMove = GetComponent<PlayerMovement>();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "leftTree")
        {
            pMove.canIUseItD = false;
        }
        else if (other.tag == "rightTree")
        {
            pMove.canIUseItA = false;
        }
        else if (other.tag == "forTree")
        {
            pMove.canIUseItS = false;
        }
        else if (other.tag == "backTree")
        {
            pMove.canIUseItW = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "leftTree" || other.tag == "backTree" || other.tag == "forTree" || other.tag == "rightTree")
        {
            pMove.canIUseItW = true;
            pMove.canIUseItS = true;
            pMove.canIUseItA = true;
            pMove.canIUseItD = true;
        }
    }
}
