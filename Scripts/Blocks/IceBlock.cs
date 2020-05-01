using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBlock : MonoBehaviour
{
    private Wood _interactionBlock;
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Fire")
        {
            _interactionBlock = collider.gameObject.GetComponent<Wood>();
            if (_interactionBlock != null)
            {
                _interactionBlock.ReceiveDamage();
            }
            else
            {
                Destroy(collider.gameObject);
            }
        }
    }
}
