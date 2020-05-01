using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _moveForce;

    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private SpriteRenderer _sprite;

    private Directions _moveDirection = Directions.Idle;

    private float _minSpeed = 1.0f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (_rigidbody.velocity.magnitude < _minSpeed)
        {
            _rigidbody.velocity = Vector2.zero;
            _moveDirection = Directions.Idle;
        }

        if (_moveDirection == Directions.Up)
        {
            _animator.Play("WalkUp");
            return;
        }
        if(_moveDirection == Directions.Down)
        {
            _animator.Play("WalkDown");
            return;
        }
        if(_moveDirection == Directions.Left)
        {
            _animator.Play("WalkHorizontal");
            return;
        }
        if(_moveDirection == Directions.Right)
        {
            _animator.Play("WalkHorizontal");
            return;
        }
        if(_moveDirection == Directions.Idle)
        {
            _animator.Play("Idle");
        }
    }

    public void MoveUp()
    {
        _moveDirection = Directions.Up;
        Vector2 direction = transform.up * Input.GetAxis("Vertical");

        Move(direction);
    }

    public void MoveDown()
    {
        _moveDirection = Directions.Down;
        Vector2 direction = transform.up * Input.GetAxis("Vertical");

        Move(direction);
    }

    public void MoveLeft()
    {
        _moveDirection = Directions.Left;
        Vector2 direction = transform.right * Input.GetAxis("Horizontal");
        _sprite.flipX = false;

        Move(direction);
    }

    public void MoveRight()
    {
        _moveDirection = Directions.Right;
        Vector2 direction = transform.right * Input.GetAxis("Horizontal");
        _sprite.flipX = true;

        Move(direction);
    }
    private void Move(Vector2 direction)
    {
        _rigidbody.velocity += direction * _moveForce;
        _rigidbody.velocity = Vector2.ClampMagnitude(_rigidbody.velocity, _moveForce);
    }

    public void ReceiveDamage()
    {
        Destroy(gameObject);
    }

    public enum Directions
    {
        Up, 
        Down,
        Left,
        Right,
        Idle
    }
}
