/*
 * By: Esther Strathy
 * 11/6/19
 * Description: stores and displays score information;
 * 
 * 
 */



 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
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
        Text myTextright = GetComponent<Text>();
        myTextright.text = FindObjectOfType<balldestroy>().scoreright.ToString();
    }
}
