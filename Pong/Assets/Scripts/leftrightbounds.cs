using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftrightbounds : MonoBehaviour
{
    AudioSource goal;
    // Start is called before the first frame update
    void Start()
    {
        goal = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        goal.Play();
    }
}
