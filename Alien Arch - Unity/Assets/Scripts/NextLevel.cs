using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    //Public variable editable in unity
    public string targetScene = "";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            changeScene();
        }
        
    }

    public void changeScene()
    {
        SceneManager.LoadScene(targetScene);
    }

}
