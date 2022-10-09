using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using TMPro;
using System;
using UnityEngine;
   
    public class TimeCounter : MonoBehaviour
    {

        private TMP_Text m_textMeshPro;
        
        private float currentTime;

        public float displayTime;
        public bool isRunning=true;
        void Start()
        {
           
        }


        void Update()
        {
            if(isRunning)
            {
            m_textMeshPro = GetComponent<TMP_Text>();
            currentTime+=Time.deltaTime;
            displayTime=(float) (Math.Truncate((double)currentTime*100.0) / 100.0);
            m_textMeshPro.text="Time: " + displayTime.ToString();
            }
            
        }

    }