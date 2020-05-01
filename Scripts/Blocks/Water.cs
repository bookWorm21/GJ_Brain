using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    private Player _player;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if( collider.tag != "Wood")
        {
            StartCoroutine(KillHero(collider));
        }
    }

    private IEnumerator KillHero(Collider2D collider)
    {
        yield return new WaitForSeconds(1.5f);

        _player = GetComponent<Player>();
        if(_player != null)
        {
            _player.ReceiveDamage();
        }
    }
}
