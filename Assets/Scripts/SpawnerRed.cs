using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRed : MonoBehaviour
{
    public GameObject REDCUBE;
    public Transform point;
    public Transform point2;
    public Transform point3;
    float interval = 3.5f;
    private Flag fl;

    // Start is called before the first frame update
    void Start()
    {
        fl = GameObject.Find("FLAG").GetComponent<Flag>();

    }

    // Update is called once per frame
    void Update()
    {

        if(fl.Ready == false) {

            if(interval <= 0f) {

                int rand = Random.Range(1, 4);
                if(rand == 1) {
                    GameObject _cube = Instantiate(REDCUBE, point.position, point.rotation);
                    StartCoroutine(wait(_cube));
                }

                if(rand == 2) {
                    GameObject _cube = Instantiate(REDCUBE, point2.position, point2.rotation);
                    StartCoroutine(wait(_cube));
                }

                if(rand == 3) {
                    GameObject _cube = Instantiate(REDCUBE, point3.position, point3.rotation);
                    StartCoroutine(wait(_cube));
                }
                interval = 3.5f;


            }
            else {
                interval -= Time.deltaTime;
            }

        }

    }
    IEnumerator wait(GameObject fuck) {
        yield return new WaitForSeconds(1f);  
        int forceRand = Random.Range(-5, -25); 
        fuck.GetComponent<Rigidbody>().AddForce(transform.forward * forceRand, ForceMode.Impulse);
    }
}
