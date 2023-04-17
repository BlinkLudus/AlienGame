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
        changeScene();
    }

    public void changeScene()
    {
        SceneManager.LoadScene(targetScene);
    }

}
