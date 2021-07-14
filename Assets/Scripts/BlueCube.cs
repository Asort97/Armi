using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCube : MonoBehaviour
{
    public GameObject greenBot_pref;
    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Transform point4;

    

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;

    public Transform centerPoint;   

    private SpawnerCube sc;


    public GameObject nukePref;



    int randCount;
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(greenBot_pref, gameObject.transform);
        sc = GameObject.Find("SpawnerGreen").GetComponent<SpawnerCube>();
    }

    private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "floor") {
            sc.Crowded = false;

            randCount = Random.Range(1, 5);
            Debug.Log(randCount);
            if(randCount == 1) {
                Instantiate(greenBot_pref, point1.position, Quaternion.identity);
                var text_1 = Instantiate(text1, centerPoint.position, Quaternion.identity);
                Destroy(gameObject);
     
            }
            if(randCount == 2) {
                Instantiate(greenBot_pref, point1.position, Quaternion.identity);
                Instantiate(greenBot_pref, point2.position, Quaternion.identity);
                var text_2 = Instantiate(text2, centerPoint.position, Quaternion.identity);
                Destroy(gameObject);
       
            }
            if(randCount == 3) {
                Instantiate(greenBot_pref, point1.position, Quaternion.identity);
                Instantiate(greenBot_pref, point2.position, Quaternion.identity);
                Instantiate(greenBot_pref, point3.position, Quaternion.identity);
                var text_3 = Instantiate(text3, centerPoint.position, Quaternion.identity);
                Destroy(gameObject);
          
            }
            if(randCount == 4) {
                Instantiate(greenBot_pref, point1.position, Quaternion.identity);
                Instantiate(greenBot_pref, point2.position, Quaternion.identity);
                Instantiate(greenBot_pref, point3.position, Quaternion.identity);
                Instantiate(greenBot_pref, point4.position, Quaternion.identity);
                var text_4 = Instantiate(text4, centerPoint.position, Quaternion.identity);
                Destroy(gameObject);
              
            }
            Instantiate(nukePref, centerPoint.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
