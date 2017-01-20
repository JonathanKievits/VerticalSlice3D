using System.Collections;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Train" || other.tag == "Car")
        {
            transform.localScale = new Vector3(1,1,0.01f);
            GetComponent<PlayerMovement>().enabled = false;
            StartCoroutine(Dying());
        }
    }

    private IEnumerator Dying()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(gameObject);
    }
}
