using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using TMPro;
using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

    public class ScoreCounter : MonoBehaviour
    {


        private TMP_Text m_textMeshPro;
        public int currentKills;
        public int score;

        public bool hasBeenApplied=false;
        void Start()
        {
            GameObject thePlayer = GameObject.Find("Player");
            FirstPersonController playerControl = thePlayer.GetComponent<FirstPersonController>();
            currentKills=playerControl.killCount;
        }


        void Update()
        {
            GameObject thePlayer = GameObject.Find("Player");
            FirstPersonController playerControl = thePlayer.GetComponent<FirstPersonController>();
            m_textMeshPro = GetComponent<TMP_Text>();
            if(playerControl.killCount>currentKills)
            {
                score=score+500*(playerControl.killCount-currentKills);
                m_textMeshPro.text="Score: " + score.ToString();
                currentKills=playerControl.killCount;
            }
            if(playerControl.enabled==false && !hasBeenApplied)
            {
                GameObject theTime = GameObject.Find("Time");
                TimeCounter timeController = theTime.GetComponent<TimeCounter>();
                GameObject theWin = GameObject.Find("WinScript");
                WinTrigger winController = theWin.GetComponent<WinTrigger>();
                bool hasWon=winController.hasWon;
                float scoreTime = timeController.displayTime;
                scoreTime=(1/scoreTime)*5000;
                scoreTime=(float)Math.Ceiling(scoreTime);
                score+=(int)scoreTime;
                if(hasWon)
                {
                    score+=1000;
                }
                m_textMeshPro.text="Score: " + score.ToString();
                hasBeenApplied=true;
            }
            
        }

    }