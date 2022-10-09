using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class EnemyController : MonoBehaviour
{
    
    public float enemySpeed=5f;
    public int direction = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject thePlayer = GameObject.Find("Player");
        FirstPersonController playerControl = thePlayer.GetComponent<FirstPersonController>();
        if(playerControl.health!=0)
        {
            transform.position = transform.position + Vector3.left*Time.deltaTime*enemySpeed;
            if(transform.position.x<-2.8f)
            {
                Debug.Log("Went through the invisible wall");
                GameObject enemy= this.gameObject;
                Destroy(enemy);
            }
            if(this.gameObject.name.Contains("Bouncing"))
            {
                if(transform.position.y>=5 || transform.position.y<0)
                {
                    direction = -direction;
                }
                transform.position= transform.position + Vector3.down*Time.deltaTime*enemySpeed*direction;
            }
        }
    }
}
