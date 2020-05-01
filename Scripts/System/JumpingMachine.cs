using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingMachine : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _rigidbody.velocity = Vector2.up * 5.0f;
    }
    
}
