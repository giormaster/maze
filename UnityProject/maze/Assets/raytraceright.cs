using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raytraceright : MonoBehaviour
{
    float distance = 5f;
    RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        hit = Physics2D.Raycast(transform.position, transform.up, distance);
        if (hit.collider != null)
        {
            Debug.DrawRay(transform.position, hit.point, Color.white);
            print("collisionsa detected");
        }
    }
}
