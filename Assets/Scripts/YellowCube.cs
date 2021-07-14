using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCube : MonoBehaviour
{

    public GameObject Zona1;
    public GameObject Zona2;
    public GameObject Zona3;
    public Transform point;

    public GameObject nukePref;

    int rand;
    SpawnerCube sc;

    void Start() {
        sc = GameObject.Find("SpawnerGreen").GetComponent<SpawnerCube>();
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "floor") {
            sc.Crowded = false;
            rand = Random.Range(1, 4);

            if(rand == 1 ) {
                Instantiate(Zona1, point.position, Quaternion.identity);
            }

            if(rand == 2 ) {
                Instantiate(Zona2, point.position, Quaternion.identity);
            }

            if(rand == 3 ) {
                Instantiate(Zona3, point.position, Quaternion.identity);
            }
            Instantiate(nukePref, point.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
