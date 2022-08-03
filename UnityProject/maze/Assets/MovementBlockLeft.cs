using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBlockLeft : MonoBehaviour
{
    [SerializeField] private GameObject blockleft;
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag != "encounter" && collider.gameObject.tag != "helpcard")
        {
            blockleft.SetActive(false);
        }
    }
}
