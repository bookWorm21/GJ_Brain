using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private float _t = 0;
    private Vector3 _startPoint;
    
    private void Start()
    {
        _startPoint = transform.position;
    }
    public void Update()
    {
        transform.position = Vector3.Lerp(
            _startPoint, _startPoint + transform.right * (-1.1f), _t );
      
        _t += 0.01f;
    }
}
