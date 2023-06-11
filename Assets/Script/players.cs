using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class players : MonoBehaviour
{
    public GameObject StartSpot;
    public GameObject PathEndSpot;
    public bool reachedHome;
    public List<GameObject> HomePath;
    public bool canPlay;
    public TMP_Text Value;

    public void SetValue(string vlaue)
    {
        Value.text = vlaue;
    }
}
