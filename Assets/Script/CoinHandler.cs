using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public playerColor playerColor;
    gameManager _gm;
    public bool hasSpawned=false;
    private players _player;
    public int pos;
    public int H_POS;
    public int total_moves = 0;
    int lastRunway = 0;

    private void Start()
    {
        _gm = gameManager.instance;
        _player = GetComponentInParent<players>();

    }
    public void ClickHandler()
    {
        if(_player.canPlay)
        {
            Debug.Log("Make a move");
            
            makeMove();
        }
    }
    void makeMove()
    {
        lastRunway = 0;
        if (!hasSpawned)
        {
            gameObject.transform.position = _player.StartSpot.transform.position;
            Debug.Log(_player.StartSpot.gameObject.name);
            pos = _gm.GetPosition(_player.StartSpot);
            hasSpawned = true;
        }
        else if(total_moves+_gm.DiceValue<=50)
        {
            total_moves += _gm.DiceValue;
            pos = (int)(pos + _gm.DiceValue) % _gm.PathLength;
            transform.position = _gm.path[pos].transform.position;
        }
        else if(total_moves>=50)
        {
            Debug.Log("Move Towards Home Now");
            moveToHome(_gm.DiceValue);
        }
        else if (total_moves <= 55)
        {
            lastRunway = 50 - pos;
            var split_dice = _gm.DiceValue - lastRunway;
            Debug.Log(lastRunway);
            Debug.Log(split_dice);
            total_moves += lastRunway;
            pos = (int)(pos + lastRunway) % _gm.PathLength;
            transform.position = _gm.path[pos].transform.position;
            moveToHome(split_dice);
        }
    }

    public void moveToHome(int steps)
    {
        Debug.Log(steps);
        total_moves += steps;
        pos = (int)(pos + steps);
        H_POS = (pos - 51) - lastRunway;
        if (H_POS >= 5)
        {
            Debug.Log("Score Home");
            transform.position = _player.HomePath[5].transform.position;
        }
        else
        {
            transform.position = _player.HomePath[H_POS].transform.position;
        }
    }


    


}
