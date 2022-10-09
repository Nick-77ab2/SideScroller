using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndScore : MonoBehaviour
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
        GameObject theScore = GameObject.Find("Score");
        ScoreCounter scoreController = theScore.GetComponent<ScoreCounter>();
        m_textMeshPro.text="Score: " + scoreController.score;
    }
}
