using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_green : MonoBehaviour
{
    public Sprite Plate2;
    public SpriteRenderer Renderhelp;
    private bool finish = false;
    public Helpencounter Helpenc;
    public GameObject Encount;
    public GameObject Canv;
    // Start is called before the first frame update
    void Start()
    {
        Renderhelp = gameObject.GetComponent<SpriteRenderer>();

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
                finish = true;
                Helpenc.onhelp();
                Renderhelp.sprite = Plate2;
            }
        }

    }
}
