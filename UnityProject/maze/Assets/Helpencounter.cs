using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helpencounter : MonoBehaviour
{
    public Sprite final;
    public pmove player;
    public GameObject Canv;
    public GameObject CurrentHelpEncounter;
    public SpriteRenderer Helpencounterrender;
    public GCards[] Cards;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onclose();
            
        }
    }
    public void onhelp()
    {
        if (player.Gtally == 12)
        {
            Helpencounterrender.sprite = final;
        }
        else
        {
            bool done = false;
            int i;
            i = Random.Range(0, Cards.Length);
            while (done != true)
            {
                if (Cards[i].Got == true)
                {
                    if (i == 11)
                    {
                        i = 1;
                    }
                    else
                    {
                        i += 1;
                    }

                }
                else
                {
                    done = true;
                    Helpencounterrender.sprite = Cards[i].GCardSprite;
                    Cards[i].Got = true;
                    player.Gtally += 1;
                }

            }
        }
        

    }
    public void onclose()
    {
        CurrentHelpEncounter.SetActive(false);
        Canv.SetActive(true);
    }
}
