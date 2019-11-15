using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class balldestroy : MonoBehaviour
{
    public string NextScene = "player1win";
    public string NextScene2 = "player2win";

    // Start is called before the first frame update
    public float scoreleft = 0f;
    public float scoreright = 0f;
    public GameObject ball;
    Vector3 respawnposition = new Vector3(0f, 0f, 0f);
 
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "rightbound" || collision.gameObject.name == "leftbound")
        {
            if (transform.position.x > 0)
            {

                scoreleft++;
            }
            if (transform.position.x < 0)
            {

                scoreright++;
            }
            transform.position = respawnposition;
            if (scoreleft >= 11)
            {

                SceneManager.LoadScene(NextScene);
            }
            if (scoreright >= 11)
            {
                SceneManager.LoadScene(NextScene2);
            }
        }
    } 
} 
