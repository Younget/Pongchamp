using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Scoreboardleft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }
    public void UpdateScore()
    {
        Text myTextleft = GetComponent<Text>();
        myTextleft.text = FindObjectOfType<balldestroy>().scoreleft.ToString();
    }
}
