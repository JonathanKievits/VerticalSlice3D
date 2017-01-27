using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImWatchingYou : MonoBehaviour {

    [SerializeField]private GameObject _target;
    [SerializeField]private GameObject _player;

    [SerializeField]private float xMargin = 1f;
    [SerializeField]private float yMargin = 1f;
    [SerializeField]private float zMargin = 1f;
    [SerializeField]private float _smooth = 0.1f;

    private Vector3 _velocity;
    private Transform _tfm;

    void Start()
    {
        _tfm = transform;
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (CheckXMargin())
        {
            _tfm.position = new Vector3(Mathf.SmoothDamp(_tfm.position.x, _target.transform.position.x, ref _velocity.x, _smooth), _tfm.position.y, _tfm.position.z);
        }
        if (CheckYMargin())
        {
            _tfm.position = new Vector3(_tfm.position.x, Mathf.SmoothDamp(_tfm.position.y, _target.transform.position.y, ref _velocity.y, _smooth), _tfm.position.z);
        }
        if (CheckZMargin())
        {
            _tfm.position = new Vector3(_tfm.position.x, _tfm.position.y, Mathf.SmoothDamp(_tfm.position.z, _target.transform.position.z, ref _velocity.z, _smooth));
        }
    }

    bool CheckXMargin()
    {
        return Mathf.Abs(_tfm.position.x - _player.transform.position.x) > xMargin;
    }
    bool CheckYMargin()
    {
        return Mathf.Abs(_tfm.position.y - _player.transform.position.y) > yMargin;
    }
    bool CheckZMargin()
    {
        return Mathf.Abs(_tfm.position.z - _player.transform.position.z) > zMargin;
    }
}
