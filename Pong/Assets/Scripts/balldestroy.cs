using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balldestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float scoreleft = 0f;
    public float scoreright = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.x > 0)
            scoreleft++;
        if (transform.position.x < 0)
            scoreright++; 
        Destroy(gameObject);
    }
}
