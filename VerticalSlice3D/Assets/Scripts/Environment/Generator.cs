using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    [SerializeField]private GameObject[] tracks;
    [SerializeField]private Transform trackSpawnerPos;
    private float newPos;
    public static Generator generator;

    private float waitTime;
    private GameObject track;

    private void Start()
    {
        generator = this;
        newPos = 2.5f;
        waitTime = 0.1f;
        Track();
    }

    private void Track()
    {
        track = Instantiate(tracks[Random.Range(0, tracks.Length)], trackSpawnerPos.position, Quaternion.identity) as GameObject;
        Vector3 temp = trackSpawnerPos.position;
        temp.y = 0;
        temp.x = 0;
        temp.z += 2.5f;
        trackSpawnerPos.position = temp;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        Track();
    }
}
