using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndKills : MonoBehaviour
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
        GameObject theKills = GameObject.Find("Kills");
        NumKills killController = theKills.GetComponent<NumKills>();
        m_textMeshPro.text="Kills: " + killController.currentKills;

    }
}
