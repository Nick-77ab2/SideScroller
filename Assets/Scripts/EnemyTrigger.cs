using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class EnemyTrigger : MonoBehaviour
{

    public float enemySpeed=5f;
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
        if(other.gameObject==GameObject.Find("Sword"))
        {
             //create the player for adding kill to killCount
            GameObject thePlayer = GameObject.Find("Player");
            FirstPersonController playerControl = thePlayer.GetComponent<FirstPersonController>();

            playerControl.killCount+=1;

            Debug.Log("I'm Dead GUAAAAAGHAAGGH");

            GameObject enemy= this.gameObject;
            GameObject parent = enemy.transform.parent.gameObject;
            //parent.GetComponentInChildren<Renderer>().enabled = false;
            Destroy(parent);
        }
    }
}
