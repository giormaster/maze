using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum Playerturn { PLAYER1, PLAYER2, PLAYER3, PLAYER4, PLAYER5 }

public class pmove : MonoBehaviour
{
    //arrowcontroller
    [SerializeField] private GameObject arrowup;
    [SerializeField] private GameObject arrowdown;
    [SerializeField] private GameObject arrowleft;
    [SerializeField] private GameObject arrowright;
    //
    public int Gtally = 0;
    public GameObject Playnumb;
    public GameObject Help;
    public GameObject HEncount;
    public GameObject Encount;
    public Diceroller droll;
    public GameObject gameObjectToMove;
    public Playerturn state;
    public TMP_Text currentturn;
    int players;
    //move with arrows
    public void moveleft()
    {
        if (droll.movement > 0)
        {
            onmoveactivation();
            gameObjectToMove.transform.position = gameObjectToMove.transform.position + new Vector3(-90, 0, 0);
            droll.movement -= 1;
            if (droll.movement == 0)
            {
                turnchanger();
            }
        }
        
    }
    public void moveright()
    {
        if (droll.movement > 0)
        {
            onmoveactivation();
            gameObjectToMove.transform.position = gameObjectToMove.transform.position + new Vector3(90, 0, 0);
            droll.movement -= 1;
            if (droll.movement == 0)
            {
                turnchanger();
            }
        }
       
    }
    public void moveup()
    {
        if (droll.movement > 0)
        {
            onmoveactivation();
            gameObjectToMove.transform.position = gameObjectToMove.transform.position + new Vector3(0, 85, 0);
            droll.movement -= 1;
            if (droll.movement == 0)
            {
                turnchanger();
            }
        }
        
        
    }
    public void movedown()
    {
        if (droll.movement > 0)
        {
            onmoveactivation();
            gameObjectToMove.transform.position = gameObjectToMove.transform.position + new Vector3(0, -85, 0);
            droll.movement -= 1;
            if (droll.movement == 0)
            {
                turnchanger();
            }
        }
        
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        state = Playerturn.PLAYER1;
        currentturn.text = "Player 1";
        HEncount.SetActive(false);
        Help.SetActive(false);
        Encount.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        
    }
    public void turnchanger()
    {
        if (players == 2)
        {
            onturnchange2p();
        }
        else if (players == 3)
        {
            onturnchange3p();
        }
        else if (players == 4)
        {
            onturnchange4p();
        }
        else
        {
            onturnchange5p();
        }
    }
    public void onturnchange2p()
    {
        if (state == Playerturn.PLAYER1)
        {
            state = Playerturn.PLAYER2;
            currentturn.text = "Player 2";
        }
        else
        {
            state = Playerturn.PLAYER1;
            currentturn.text = "Player 1";
        }
    }
    
    public void onturnchange3p()
    {
        if (state == Playerturn.PLAYER1)
        {
            state = Playerturn.PLAYER2;
            currentturn.text = "Player 2";
        }
        else if (state == Playerturn.PLAYER2)
        {
            state = Playerturn.PLAYER3;
            currentturn.text = "Player 3";
        }
        else
        {
            state = Playerturn.PLAYER1;
            currentturn.text = "Player 1";
        }
    }
    public void onturnchange4p()
    {
        if (state == Playerturn.PLAYER1)
        {
            state = Playerturn.PLAYER2;
            currentturn.text = "Player 2";
        }
        else if (state == Playerturn.PLAYER2)
        {
            state = Playerturn.PLAYER3;
            currentturn.text = "Player 3";
        }
        else if (state == Playerturn.PLAYER3)
        {
            state = Playerturn.PLAYER4;
            currentturn.text = "Player 4";
        }
        else
        {
            state = Playerturn.PLAYER1;
            currentturn.text = "Player 1";
        }
    }
    public void onturnchange5p()
    {
        if (state == Playerturn.PLAYER1)
        {
            state = Playerturn.PLAYER2;
            currentturn.text = "Player 2";
        }
        else if (state == Playerturn.PLAYER2)
        {
            state = Playerturn.PLAYER3;
            currentturn.text = "Player 3";
        }
        else if (state == Playerturn.PLAYER3)
        {
            state = Playerturn.PLAYER4;
            currentturn.text = "Player 4";
        }
        else if (state == Playerturn.PLAYER4)
        {
            state = Playerturn.PLAYER5;
            currentturn.text = "Player 5";
        }
        else
        {
            state = Playerturn.PLAYER1;
            currentturn.text = "Player 1";
        }
    }

    public void playernumber(int pnumb)
    {
        players = pnumb;
        Playnumb.SetActive(false);
    }
    public void onmoveactivation()
    {
        arrowup.SetActive(true);
        arrowdown.SetActive(true);
        arrowleft.SetActive(true);
        arrowright.SetActive(true);
    }

}
