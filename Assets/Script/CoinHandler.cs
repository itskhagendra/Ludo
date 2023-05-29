using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public playerColor playerColor;
    public GameObject StartingSpot;
    gameManager _gm;

    private void Start()
    {
        _gm = gameManager.instance;
    }
    public void ClickHandler()
    {
        Debug.Log("It Works");
    }

}
