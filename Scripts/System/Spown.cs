using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown : MonoBehaviour
{
    [SerializeField] private GameObject _block;
    [SerializeField] private GameObject _wire;

    private Wood _wood;
    private GameObject _object;
    private bool _isUseWire = false;

    private GameObject _tempBlock;

    private void Start()
    {
        CreateBlock();
    }

    public void OnClickToggle()
    {
        _object.transform.position = _tempBlock.transform.position;
        if (_isUseWire == false)
        {
            _isUseWire = true;
            _object.SetActive(true);
            _tempBlock.SetActive(false);
        }
        else
        {
            _isUseWire = false;
            _object.SetActive(false);
            _tempBlock.SetActive(true);
        }
    }
    private void CreateBlock()
    {
        _tempBlock = Instantiate(_block, transform.position, Quaternion.identity);
        _wood = _tempBlock.GetComponent<Wood>();
        _wood.Rigidbody.velocity = transform.up * 6.0f;

        if (_wire != null)
        {
            _object = Instantiate(_wire, transform.position, Quaternion.identity);
            _object.SetActive(false);
        }
    }
}
