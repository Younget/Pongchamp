/*
 * By:Esther Strathy
 * 11/6/19
 * Controls paddle movement 
 * 
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D myRB;
    public float movement = 0.1f;

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(7.5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        Paddlemove(); 
    }

    void Paddlemove()
    {
        if (Input.GetKey("down") == true && transform.position.y >= -4)
        {
            transform.position -= new Vector3(0f, movement, 0f);
        }
        if (Input.GetKey("up") == true && transform.position.y <=4)
        {
            transform.position += new Vector3(0f, movement, 0f);
        }
    }
}
