using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = collision.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
