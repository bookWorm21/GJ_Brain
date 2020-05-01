using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveOpportunity : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;
    public void OnTriggerEnter2D( Collider2D collider)
    {
        _canvas.enabled = true;
    }

    public void OnTriggerExit2D( Collider2D collider)
    {
        _canvas.enabled = false;
    }
}
