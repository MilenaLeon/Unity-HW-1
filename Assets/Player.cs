using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    public int counter = 0;
    private int _directionIndex;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
    }

    private void OnDisable()
    {
        var _velocity = Vector3.zero;
        _velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = _velocity;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _directionIndex = _directionIndex == 0 ? 1 : 0;
        }
    }

    private void FixedUpdate()
    {
        var _velocity = _directionIndex == 0 ? Vector3.forward  : Vector3.right;
        _velocity *= speed;
        _velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = _velocity;
        //Debug.Log(_velocity);
    }
}
