using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onReplayBtnPressed()
    {
        Debug.Log("I've been pressed");
        Cursor.visible=false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
