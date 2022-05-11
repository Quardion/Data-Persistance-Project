using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadNameInput : MonoBehaviour
{
    public string playerName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s)
    {
        playerName = s;
        Debug.Log(s);
        gameObject.GetComponent<DataContainer>().GetPlayerName();
    }
}
