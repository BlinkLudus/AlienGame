using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 10;
    private int currentHealth;
    public string targetScene = "";
    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void ChangeHealth(int changeAmount)
    {
        currentHealth = currentHealth + changeAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);
        if(currentHealth == 0)
        {
            changeScene();
            Kill();
        }
    }

    public void Kill()
    {
        Destroy(gameObject);
    }

    public void changeScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}
