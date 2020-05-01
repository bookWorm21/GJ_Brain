using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHouse : MonoBehaviour
{
    [SerializeField] GameObject _effect1;
    [SerializeField] Wire[] _wires;
    [SerializeField] Door _door;
    [SerializeField] SpriteRenderer _doorSprite;
    [SerializeField] SpriteRenderer _keySprite;

    public void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Conductor")
        {
            _effect1.SetActive(true);
            for (int i = 0; i < _wires.Length; i++)
            {
                _wires[i].IsActive = true;
            }

            _door.enabled = true;
            _keySprite.flipX = true;
            _doorSprite.flipX = false;
        }
    }

    public void OnTriggerExit2D(Collider2D collider)
    {
        _effect1.SetActive(false);
        for (int i = 0; i < _wires.Length; i++)
        {
            _wires[i].IsActive = false;
        }
        _keySprite.flipX = false;
    }
}
