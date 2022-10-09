using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndTime : MonoBehaviour
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
        GameObject theTime = GameObject.Find("Time");
        TimeCounter timeController = theTime.GetComponent<TimeCounter>();
        float time = timeController.displayTime;
        m_textMeshPro.text="Time: " + time;
    }
}
