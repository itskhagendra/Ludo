using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static gameManager instance;
    public List<GameObject> players;
    public GameObject ActivePlayer;
    public int turn;
    public TMP_Text Player;
    public List<GameObject> path;
    public GameObject PB1;
    public GameObject PB2;


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
        turn = 3;
        PathLength = path.Count;
    }

    // Update is called once per frame
    private void Update()
    {
        var state = (turn % 2 == 0);
        
        PB1.SetActive(!state);
        PB2.SetActive(state);
        //Player.text = turn % 2 == 0 ? "Player 1" : "Player 2";
        
    }
    public void RollDice()
    {
            var temp = turn % 2;
            if (temp == 1)
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
    public int GetPosition(GameObject spot)
    {
        return path.IndexOf(spot);
    }
    public void MainScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
