using System.Collections;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Train")
        {
            transform.localScale = new Vector3(1,1,0.01f);
            GetComponent<PlayerMovement>().enabled = false;
            dying();
        }
    }

    IEnumerator dying()
    {

        Destroy(gameObject);
        yield return new WaitForSeconds(2.5f);
    }
}
