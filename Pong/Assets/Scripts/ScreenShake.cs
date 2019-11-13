/*
 * By:Esther STrathy
 * 11/13/19
 * Description: camera shake
 */




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
Camera camera;  
float shake = 0f;
float ShakeAmount = 0.7f;
float DecreaseFactor = 1.0f;

    private void Start()
    {
        camera = GetComponent<Camera>(); 
    }
    public void Update()
    {
        if (shake > 0)
        {
            camera.transform.localPosition = Random.insideUnitSphere * ShakeAmount;
            shake -= Time.deltaTime * DecreaseFactor;

        }
        else
        {
            shake = 0.0f;
        }
    }
}