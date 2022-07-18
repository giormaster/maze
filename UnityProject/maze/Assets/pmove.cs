using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pmove : MonoBehaviour
{
    public Diceroller droll;
    public GameObject gameObjectToMove;
    //move with arrows
    public void moveleft()
    {
        if (droll.movement > 0)
        {
            gameObjectToMove.transform.position = gameObjectToMove.transform.position + new Vector3(-55, 0, 0);
            droll.movement -= 1;
        }
        
    }
    public void moveright()
    {
        if (droll.movement > 0)
        {
            gameObjectToMove.transform.position = gameObjectToMove.transform.position + new Vector3(55, 0, 0);
            droll.movement -= 1;
        }
       
    }
    public void moveup()
    {
        if (droll.movement > 0)
        {
            gameObjectToMove.transform.position = gameObjectToMove.transform.position + new Vector3(0, 40, 0);
            droll.movement -= 1;
        }
        
        
    }
    public void movedown()
    {
        if (droll.movement > 0)
        {
            gameObjectToMove.transform.position = gameObjectToMove.transform.position + new Vector3(0, -40, 0);
            droll.movement -= 1;
        }
        
        
    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        print("collide!!");
    }
}
