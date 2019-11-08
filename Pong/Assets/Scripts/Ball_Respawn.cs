using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Respawn : MonoBehaviour
{
    public GameObject prefab;
    float ballcount;
    Vector3 respawnposition = new Vector3(0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("ball").Length < 1)
        {
            Instantiate(prefab, respawnposition, Quaternion.identity);
        }
    }
}
