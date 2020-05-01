using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    [SerializeField] private bool _isActive;

    private Wood _wood;
    private Player _player;

    public bool IsActive
    {
        get
        {
            return _isActive;
        }
        set
        {
            _isActive = value;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (_isActive)
        {
            _wood  = collision.gameObject.GetComponent<Wood>();
            if (_wood != null)
            {
                _wood.ReceiveDamage();
            }
            else
            {
                _player = collision.gameObject.GetComponent<Player>();
                if(_player != null)
                {
                    _player.ReceiveDamage();
                }
            }
        }
    }
}
