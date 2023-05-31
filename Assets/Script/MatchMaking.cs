using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MatchMaking : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    TMP_Text timerText;
    [SerializeField]
    int timer = 5;
    private void OnEnable()
    {
        StartCoroutine("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = timer.ToString();
        if (timer <= 0)
            SceneManager.LoadScene("GameScene");
    }
    IEnumerator Timer()
    {
        while (timer > 0)
        {

            yield return new WaitForSeconds(1);
            timer--;
        }
        
    }
}
