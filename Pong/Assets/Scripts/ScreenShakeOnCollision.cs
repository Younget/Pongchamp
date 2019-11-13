﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShakeOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag == "wall")
        {
            ScreenShakeInitiate();
        }
    }
    public void ScreenShakeInitiate()
    {
        gameObject.GetComponent<ScreenShake>().Update();

    }
}
