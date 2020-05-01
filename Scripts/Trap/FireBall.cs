using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private float _t = 0;
    private Vector3 _startPoint;

    private Wood _wood;
    private Player _player;
    private void Start()
    {
        _startPoint = transform.position;
    }
    public void Update()
    {
        transform.position = Vector3.Lerp(
            _startPoint, _startPoint + transform.right * (35.0f), _t);

        _t += 0.008f;
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        _wood = collider.gameObject.GetComponent<Wood>();
        if (_wood != null)
        {
            _wood.ReceiveDamage();
        }
        else
        {
            _player = collider.gameObject.GetComponent<Player>();
            if (_player != null)
            {
                _player.ReceiveDamage();
            }
        }
    }
}
