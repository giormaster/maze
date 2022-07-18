using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechange2 : MonoBehaviour
{
    public Sprite[] spritearray;
    public Diceroller drol;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (drol.dice2 == 1)
        {
            spriteRenderer.sprite = spritearray[0];
        }
        if (drol.dice2 == 2)
        {
            spriteRenderer.sprite = spritearray[1];
        }
        if (drol.dice2 == 3)
        {
            spriteRenderer.sprite = spritearray[2];
        }
        if (drol.dice2 == 4)
        {
            spriteRenderer.sprite = spritearray[3];
        }
        if (drol.dice2 == 5)
        {
            spriteRenderer.sprite = spritearray[4];
        }
        if (drol.dice2 == 6)
        {
            spriteRenderer.sprite = spritearray[5];
        }
    }
}
