using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTwoOpportunity : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _block;
    private Vector3 _tempPoint;

    public void OnClickSpecialButton()
    {
        _tempPoint = _player.transform.position;
        _player.transform.position = _block.transform.position;
        _block.transform.position = _tempPoint;
    }
}
