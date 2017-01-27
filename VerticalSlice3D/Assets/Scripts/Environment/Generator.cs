using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    [SerializeField]private GameObject[] _grounds;
    [SerializeField]private Transform _groundSpawnerPos;
    private float _newPos;
    public static Generator generator;

    private float _waitTime;
    private GameObject _ground;

    private void Start()
    {
        generator = this;
        _newPos = 5f;
        _waitTime = 0.1f;
        Ground();
    }

    private void Ground()
    {
        _ground = Instantiate(_grounds[Random.Range(0, _grounds.Length)], _groundSpawnerPos.position, Quaternion.identity) as GameObject;
        Vector3 temp = _groundSpawnerPos.position;
        temp.y = 0;
        temp.x = 0;
        temp.z += _newPos;
        _groundSpawnerPos.position = temp;
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(_waitTime);
        Ground();
    }
}
