using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WinTrigger : MonoBehaviour
{
    public bool hasWon=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Test" + other.gameObject.name);
        if(other.gameObject==GameObject.Find("Player"))
        {
            Debug.Log("Got Here");
            GameObject thePlayer = GameObject.Find("Player");
            FirstPersonController playerControl = thePlayer.GetComponent<FirstPersonController>();
            playerControl.enabled=false;
            GameObject theTime = GameObject.Find("Time");
            TimeCounter timeController = theTime.GetComponent<TimeCounter>();
            timeController.isRunning=false;
            hasWon=true;
            GameObject ui = GameObject.Find("GUI");
            GameObject thePanel = ui.transform.GetChild(2).gameObject;
            thePanel.SetActive(true);
            Cursor.visible=true;
        }
    }
}
