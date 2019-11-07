/* By: Ethan Young
 * Last Updated: 11/7/19
 * Description: Changes the scene from menu to Pong 
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangePong : MonoBehaviour
{
    public string NextScene = "Pong";

    public void ChangeScene()
    {
        SceneManager.LoadScene(NextScene);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
