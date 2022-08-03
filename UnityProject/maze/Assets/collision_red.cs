using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_red : MonoBehaviour
{
    public Sprite Plate;
    public SpriteRenderer Render;
    private bool finish = false;
    public MonsterEncounter MonstEnc;
    public GameObject Encount;
    public GameObject Canv;
    // Start is called before the first frame update
    void Start()
    {
        Render = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag != "ignorer")
        {
            if (finish == false)
            {
                Canv.SetActive(false);
                Encount.SetActive(true);
                MonstEnc.onencounter();
                finish = true;
                Render.sprite = Plate;
            }
        }
        
        
    }
}
