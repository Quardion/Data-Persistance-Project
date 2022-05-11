using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImportName : MonoBehaviour
{
    Text nameText;
    public string playerName;
    public GameObject EventSystem;

    // Start is called before the first frame update
    void Start()
    {
        EventSystem = GameObject.Find("EventSystem");
        playerName = EventSystem.GetComponent<DataContainer>().playerName;
        nameText = GetComponent<Text>();
        nameText.text = "Behold " + playerName + "'s skill!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
