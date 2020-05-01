using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Friction : MonoBehaviour
{
    [SerializeField] private float _friction;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if(_rigidbody.velocity.magnitude > 0.01f)
        {
            _rigidbody.velocity -= _rigidbody.velocity.normalized * _friction;
        }
    }
}
