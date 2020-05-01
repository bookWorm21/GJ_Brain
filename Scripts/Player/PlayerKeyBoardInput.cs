using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerKeyBoardInput : MonoBehaviour
{
    private Player _player;

    private void Start()
    {
        _player = GetComponent<Player>();
    }
    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _player.MoveLeft();
        }

        if (Input.GetKey(KeyCode.D))
        {
            _player.MoveRight();
        }

        if(Input.GetKey(KeyCode.W))
        {
            _player.MoveUp();
        }

        if(Input.GetKey(KeyCode.S))
        {
            _player.MoveDown();
        }
    }
}
