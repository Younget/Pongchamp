﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangePong : MonoBehaviour
{
    public string NextScene = "Pong";

    public void ChangeScene()
    {
        SceneManager.LoadScene(NextScene);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
