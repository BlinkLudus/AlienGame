using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public string[] messages;
    public string message1;
    public string message2;
    public string message3;
    public int messageChoice;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < messages.Length; ++i)
        {
            Debug.Log(messages[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.LogError(message2);
    }
}
