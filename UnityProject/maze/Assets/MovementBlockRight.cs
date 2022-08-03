using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBlockRight : MonoBehaviour
{
    [SerializeField] private GameObject blockright;
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag != "encounter" && collider.gameObject.tag != "helpcard")
        {
            blockright.SetActive(false);
        }
    }
}
