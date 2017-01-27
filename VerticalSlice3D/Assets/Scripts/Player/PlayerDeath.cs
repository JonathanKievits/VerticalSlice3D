using System.Collections;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Train" || other.tag == "Car")
        {
            transform.localScale = new Vector3(60,60,6f);
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<PointCounter>().enabled = false;
            StartCoroutine(Dying());
        }else if (other.tag == "OutOfBounds")
        {
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<PointCounter>().enabled = false;
            Destroy(gameObject);
        }else if (other.tag == "Drowning")
        {
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<PointCounter>().enabled = false;
            //Play splash animation
            StartCoroutine(Dying());
        }else if (other.tag == "AfkKiller")
        {
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<PointCounter>().enabled = false;
            //Play eagle animation
            StartCoroutine(Dying());
        }
    }

    private IEnumerator Dying()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(gameObject);
    }
}
