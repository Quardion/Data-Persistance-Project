using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataContainer : MonoBehaviour
{
    public static DataContainer Instance;
    public string playerName;
    public int highScore;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void GetPlayerName()
    {
        playerName = gameObject.GetComponent<ReadNameInput>().playerName;
        Debug.Log("receiving..." + playerName);
    }

    public void ReadPlayerName(string playerName)
    {
        Debug.Log("scene transmission result:" + playerName);
    }
}
