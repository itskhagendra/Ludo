using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class players : MonoBehaviour
{
    // Start is called before the first frame update
    public int Coinsin;
    public Transform startPoistion;
    public GameObject StartSpot;
    public GameObject TriggerSpot;
    public List<GameObject> CoinsAtHome;
    public GameObject HomeSprite;
    public bool isActive;
    public int dicevalue;
    public int Pos;
    public TMP_Text Counter;
    int val;
    

    // Update is called once per frame
    gameManager _gm;

    private void Start()
    {
        _gm = gameManager.instance;
    }
    public int RollDice()
    {
        dicevalue = !isActive? 6 : Random.Range(1, 6);
        Debug.Log(dicevalue);
        val = dicevalue;
        Counter.text = dicevalue.ToString(); ;
        makeMove();

        return dicevalue;
    }
    
    void Update()
    {
        Debug.LogWarning(val);
        Counter.text = val.ToString(); ;
    }
    public void Spwan()
    {
        CoinsAtHome[1].transform.position = StartSpot.transform.position;
        Pos = _gm.GetPosition(StartSpot);
        isActive = true;
    }
    public void movePlayer()
    {
        Debug.Log("Moving");
        //float x_pos = CoinsAtHome[1].transform.position.x;
        //float y_pos = CoinsAtHome[1].transform.localPosition.y <0 ? CoinsAtHome[1].transform.position.y + 80 * dicevalue: CoinsAtHome[1].transform.position.y - 80 * dicevalue;
        //CoinsAtHome[1].transform.position = new Vector2(x_pos, y_pos);
        Pos =(int) (Pos + dicevalue)%_gm.PathLength;
        CoinsAtHome[1].transform.position = _gm.path[Pos].transform.position;
        //Counter = 0;
        return;
    }

    void makeMove()
    {
        if(isActive)
            movePlayer();
        else
            Spwan();

    }
}