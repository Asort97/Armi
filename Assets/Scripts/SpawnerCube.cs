using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCube : MonoBehaviour
{

    public Transform point;
    public GameObject bluecube_pref;
    public GameObject yellowcube_pref;
     
    public bool  Crowded;
    float interval;
    
    int rand;

    void Update()
    {
        if(Crowded == false) {
            interval -= Time.deltaTime;
            if(interval <= 0f) {
                rand = Random.Range(1, 3);
                Debug.Log(rand);

                if(rand == 1) {
                    Instantiate(bluecube_pref, point.position, Quaternion.identity);
                }
                if(rand == 2) {
                    Instantiate(yellowcube_pref, point.position, Quaternion.identity);
                }
                
                Crowded = true;
                interval = 5f;
            }
            
        }
    }

    private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "blue_cube") {
            Crowded = true;
            Debug.Log("ENTER");
        }

        if(col.gameObject.tag == "yellow_cube") {
            Crowded = true;
            Debug.Log("ENTER Y");
        }
    }

    // private void OnCollisionExit(Collision col) {
    //     if(col.gameObject.tag == "blue_cube") {
    //         Crowded = false;
    //         Debug.Log("EXIT");
    //     }

    //     if(col.gameObject.tag == "yellow_cube") {
    //         Crowded = false;
    //         Debug.Log("EXITY");
    //     }
    // }
}
