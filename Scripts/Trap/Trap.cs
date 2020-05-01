using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private GameObject _fireBall;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        _fireBall.SetActive(true);
    }
}
