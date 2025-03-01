using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Triangle"))
        {
            Debug.Log("Player has tocuhed the triangle");
            string thisLevel = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(thisLevel);
        } else if (collision.CompareTag("Hexagon"))
        {
            Debug.Log("Player has touched the hexagon");
            string nextLevel = "Scene_2";
            SceneManager.LoadScene(nextLevel);
        }
    }
}
