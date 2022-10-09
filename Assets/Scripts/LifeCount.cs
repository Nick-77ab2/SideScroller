using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using TMPro;
using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
   
    public class LifeCount : MonoBehaviour
    {

        private TMP_Text m_textMeshPro;
        
        private float currentHealth=3;

        public float displayTime;
        public bool isRunning=true;
        void Start()
        {
           
        }


        void FixedUpdate()
        {
            GameObject thePlayer = GameObject.Find("Player");
            FirstPersonController playerControl = thePlayer.GetComponent<FirstPersonController>();
           if(playerControl.health<currentHealth)
            {
                currentHealth=playerControl.health;
                m_textMeshPro = GetComponent<TMP_Text>();
                m_textMeshPro.text="Lives: " + currentHealth;
            }
            
        }

    }
