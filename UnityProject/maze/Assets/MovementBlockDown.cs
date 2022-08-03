using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBlockDown : MonoBehaviour
{
    [SerializeField] private GameObject blockdown;
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag != "encounter" && collider.gameObject.tag != "helpcard")
        {
            blockdown.SetActive(false);
        }
    }
}
