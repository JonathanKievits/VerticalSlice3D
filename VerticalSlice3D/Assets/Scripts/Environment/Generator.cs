using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    [SerializeField]private GameObject[] grounds;
    [SerializeField]private Transform groundSpawnerPos;
    private float newPos;
    public static Generator generator;

    private float waitTime;
    private GameObject ground;

    private void Start()
    {
        generator = this;
        newPos = 2.5f;
        waitTime = 0.1f;
        Ground();
    }

    private void Ground()
    {
        ground = Instantiate(grounds[Random.Range(0, grounds.Length)], groundSpawnerPos.position, Quaternion.identity) as GameObject;
        Vector3 temp = groundSpawnerPos.position;
        temp.y = 0;
        temp.x = 0;
        temp.z += 2.5f;
        groundSpawnerPos.position = temp;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        Ground();
    }
}
