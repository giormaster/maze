using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEncounter : MonoBehaviour
{
    public pmove playerm;
    public Diceroller player;
    public GameObject Canv;
    public GameObject CurrentEncounter;
    public SpriteRenderer encounterrender;
    public Cards[] MonsterCards;
    // player and shadow
    [SerializeField] private GameObject playertoken;
    [SerializeField] private GameObject playershadow;
    //button and specific cards
    [SerializeField] private GameObject helpbutton;
    [SerializeField] private GameObject winbutton;
    [SerializeField] private GameObject losebutton;
    //roadmonster special event
    [SerializeField] private GameObject roadmonsterlosebutton;
    [SerializeField] private GCards roadmonsterhelp;
    //fear monster special event
    [SerializeField] private GameObject fearmonsterlosebutton;
    [SerializeField] private GCards fearmonsterhelp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onencounter()
    {
        int i;
        int j;
        i = Random.Range(0, MonsterCards.Length);
        j = Random.Range(0, MonsterCards[i].MonsterSprite.Length);
        encounterrender.sprite = MonsterCards[i].MonsterSprite[j];
        if (MonsterCards[i].Type == "RoadMonster")
        {
            winbutton.SetActive(false);
            losebutton.SetActive(false);
            roadmonsterlosebutton.SetActive(true);
            if (roadmonsterhelp.Got == true)
            {
                helpbutton.SetActive(true); 
            }
            
        }
        if (MonsterCards[i].Type == "FearMonster")
        {
            winbutton.SetActive(false);
            losebutton.SetActive(false);
            fearmonsterlosebutton.SetActive(true);
            if (fearmonsterhelp.Got == true)
            {
                helpbutton.SetActive(true);
            }

        }

    }
    public void onpass()
    {
        player.movement += Random.Range(1, 7) - player.movement;
        CurrentEncounter.SetActive(false);
        Canv.SetActive(true);
        playershadow.transform.position = playertoken.transform.position;
        backtodeafult();
    }
    public void onfail()
    {
        player.movement = 0;
        playerm.turnchanger();
        CurrentEncounter.SetActive(false);
        Canv.SetActive(true);
        playershadow.transform.position = playertoken.transform.position;
        backtodeafult();
    }
    public void roadmonsterfail()
    {
        player.movement = 0;
        playerm.turnchanger();
        CurrentEncounter.SetActive(false);
        Canv.SetActive(true);
        playertoken.transform.position = playershadow.transform.position;
        backtodeafult();
    }
    public void fearmonsterfail()
    {
        player.movement = 0;
        playerm.turnchanger();
        CurrentEncounter.SetActive(false);
        Canv.SetActive(true);
        playertoken.transform.position = playershadow.transform.position;
        backtodeafult();
    }
    public void onhelp()
    {
        if (roadmonsterhelp.Got == true)
        {
            roadmonsterhelp.Got = false;
        }
        if (fearmonsterhelp.Got == true)
        {
            fearmonsterhelp.Got = false;
        }
        CurrentEncounter.SetActive(false);
        Canv.SetActive(true);
        playershadow.transform.position = playertoken.transform.position;
        backtodeafult();
    }
    public void backtodeafult()
    {
        helpbutton.SetActive(false);
        roadmonsterlosebutton.SetActive(false);
        fearmonsterlosebutton.SetActive(false);
        winbutton.SetActive(true);
        losebutton.SetActive(true);
    }
}
