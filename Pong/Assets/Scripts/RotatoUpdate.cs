using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotato : MonoBehaviour
{
   balldestroy score;


    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<balldestroy>();
    }

    // Update is called once per frame
    void Update()
    {

        if (score.scoreleft >= 7 || score.scoreright >= 7)
        {
            transform.Rotate(0, 0, 20 * Time.deltaTime);
        }
    }
}
