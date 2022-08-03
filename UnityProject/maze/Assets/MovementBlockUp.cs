using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBlockUp : MonoBehaviour
{
    [SerializeField] private GameObject blockup;
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag != "encounter" && collider.gameObject.tag != "helpcard")
        {
            blockup.SetActive(false);
        }
    }
}
