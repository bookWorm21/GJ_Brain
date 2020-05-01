using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class Wood : MonoBehaviour
{
    [SerializeField] private GameObject _spown;
    [SerializeField] private Friction _friction;

    private Rigidbody2D _rigidbody;

    public Rigidbody2D Rigidbody
    {
        get
        {
            return _rigidbody;
        }
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ReceiveDamage()
    {
        transform.position = _spown.transform.position;
        _rigidbody.velocity = transform.up * 6.0f;
    }
}
