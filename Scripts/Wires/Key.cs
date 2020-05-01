using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] GameObject _effect1;
    [SerializeField] GameObject _effect2;
    [SerializeField] Wire[] _wires;
    [SerializeField] Door _door;
    [SerializeField] Door _door1;

    public void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Conductor")
        {
            _effect1.SetActive(true);
            _effect2.SetActive(true);
            for (int i = 0; i < _wires.Length; i++)
            {
                _wires[i].IsActive = true;
            }

            _door.enabled = true;
            _door1.enabled = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collider)
    {
        _effect1.SetActive(false);
        _effect2.SetActive(false);
        for (int i = 0; i < _wires.Length; i++)
        {
            _wires[i].IsActive = false;
        }
    }
}
