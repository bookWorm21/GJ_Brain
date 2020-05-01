using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    [SerializeField] private GameObject _wire;

    private GameObject _object;
    private bool _isUseWire = false;
    private Vector2 _point;

    private void Start()
    {
        _object = Instantiate(_wire, transform.position, Quaternion.identity);
        _object.SetActive(false);
    }
    public void OnClickToggle()
    {
        _object.transform.position = transform.position;
        if (_isUseWire == false)
        {
            _isUseWire = true;
            _object.SetActive(true);
            this.gameObject.SetActive(false);
        }
        else
        {
            _isUseWire = false;
            _object.SetActive(false);
            this.gameObject.SetActive(true);
        }
    }
}
