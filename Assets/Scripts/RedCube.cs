using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : MonoBehaviour
{


    int randCount;
    public GameObject redBot_pref;
    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Transform point4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "floor") {

            randCount = Random.Range(1, 5);
            Debug.Log(randCount);
            if(randCount == 1) {
                Instantiate(redBot_pref, point1.position, Quaternion.identity);
     
            }
            if(randCount == 2) {
                Instantiate(redBot_pref, point1.position, Quaternion.identity);
                Instantiate(redBot_pref, point2.position, Quaternion.identity);
    
       
            }
            if(randCount == 3) {
                Instantiate(redBot_pref, point1.position, Quaternion.identity);
                Instantiate(redBot_pref, point2.position, Quaternion.identity);
                Instantiate(redBot_pref, point3.position, Quaternion.identity);
          
            }
            if(randCount == 4) {
                Instantiate(redBot_pref, point1.position, Quaternion.identity);
                Instantiate(redBot_pref, point2.position, Quaternion.identity);
                Instantiate(redBot_pref, point3.position, Quaternion.identity);
                Instantiate(redBot_pref, point4.position, Quaternion.identity);
              
            }
            
            Destroy(gameObject);
        }
    }
}
