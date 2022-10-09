using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;
public class EndText : MonoBehaviour
{
    private TMP_Text m_textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_textMeshPro = GetComponent<TMP_Text>();
        GameObject thePlayer = GameObject.Find("Player");
        FirstPersonController playerControl = thePlayer.GetComponent<FirstPersonController>();
        if(playerControl.health==0)
        {
            m_textMeshPro.text="You Lost";
        }
        else
        {
            m_textMeshPro.text="You Won";
        }
        
    }
}
