using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D myRB;
    public Vector2 velocity = new Vector2(2f, 2f);
    void Start()
    {
        transform.position = new Vector3(0f, 0f,0f);
        myRB = GetComponent<Rigidbody2D>();
        myRB.AddForce(velocity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
