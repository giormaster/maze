using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diceroller : MonoBehaviour
{
    //setting variables
    public Text movetext;
    public float dice1;
    public float dice2;
    public float movement;
    // Start is called before the first frame update
    public void ondiceroll()
    {
        dice1 = Random.Range(1, 7);
        dice2 = Random.Range(1, 7);
        movement = dice1 + dice2;
    }
    void Start()
    {
        movement = 0;
        dice1 = 0;
        dice2 = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        movetext.text = "Movement:" + movement;
        //print(dice1);
        //print(dice2);
        
    }
}
