using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static gameManager instance;
    public List<GameObject> players;
    public GameObject ActivePlayer;
    public int turn;
    public TMP_Text Player;
    public List<GameObject> path;

    [HideInInspector]
    public int PathLength;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);

    }
    void Start()
    {
        turn = 0;
        PathLength = path.Count;
    }

    // Update is called once per frame
    void Update()
    {
        Player.text = turn % 2 == 0 ? "Player 1" : "Player 2";
        if (Input.GetMouseButtonDown(0))
        {
            var temp = turn % 2;
            if (temp == 0)
            {
                players[temp].GetComponent<players>().RollDice();
                Debug.Log("Calling 0");
            }
            else
            {
                players[temp].GetComponent<players>().RollDice();
                Debug.Log("Calling 1");
            }
            turn++;
        }
    }
    public int GetPosition(GameObject spot)
    {
        return path.IndexOf(spot);
    }
}
