using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _targetPoint;
    [SerializeField] private Transform _startPoint;

    private void Update()
    {
        if(_targetPoint == null)
        {
            _targetPoint = _startPoint;
        }

        Vector3 position = _targetPoint.position;
        position.z = -10.0f;
        position.y += 1.0f;

        transform.position = Vector3.Lerp(transform.position, position, _speed * Time.deltaTime);
    }

    public void SetTarget(Transform point)
    {
        _targetPoint = point;
    }
}
