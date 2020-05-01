using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharecter : MonoBehaviour
{
    [SerializeField] private GameObject _player1;
    [SerializeField] private GameObject _player2;
    [SerializeField] private CameraController _camera;

    private PlayerKeyBoardInput _currentKeyBoardInput;

    private bool _isUse = false;

    private void Start()
    {
        _currentKeyBoardInput = _player1.GetComponent<PlayerKeyBoardInput>();
    }
    public void ChangeCharacter()
    {
        if(_isUse == false)
        {
            _currentKeyBoardInput.enabled = false;

            _currentKeyBoardInput = _player2.GetComponent<PlayerKeyBoardInput>();
            _currentKeyBoardInput.enabled = true;
            _camera.SetTarget(_player2.transform);

            _isUse = true;
        }
        else
        {
            _currentKeyBoardInput.enabled = false;

            _currentKeyBoardInput = _player1.GetComponent<PlayerKeyBoardInput>();
            _currentKeyBoardInput.enabled = true;
            _camera.SetTarget(_player1.transform);

            _isUse = false;
        }
    }
}
