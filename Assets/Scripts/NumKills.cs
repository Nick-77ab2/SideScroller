using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using TMPro;
using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
   
    public class NumKills : MonoBehaviour
    {

        private TMP_Text m_textMeshPro;
        
        public float currentKills=0;

        public float displayTime;
        public bool isRunning=true;
        void Start()
        {
           
        }


        void FixedUpdate()
        {
            GameObject thePlayer = GameObject.Find("Player");
            FirstPersonController playerControl = thePlayer.GetComponent<FirstPersonController>();
            if(playerControl.killCount>currentKills)
            {
                currentKills=playerControl.killCount;
                m_textMeshPro = GetComponent<TMP_Text>();
                m_textMeshPro.text="Kills: " + currentKills;
            }
            
        }

    }
