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

    }
    public void onpass()
    {
        player.movement += Random.Range(1, 7) - player.movement;
        CurrentEncounter.SetActive(false);
        Canv.SetActive(true);

    }
    public void onfail()
    {
        player.movement = 0;
        playerm.turnchanger();
        CurrentEncounter.SetActive(false);
        Canv.SetActive(true);
    }
}
