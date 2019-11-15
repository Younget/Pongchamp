using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUpdate : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreleft >= 7)
        {
            transform.Rotate(0, 0, 50 * Time.deltaTime);
        }

        if (scoreright >= 7)
        {
            transform.Rotate(0, 0, 50 * Time.deltaTime);
        }
    }
}
