using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RedStick : MonoBehaviour
{

    public GameObject greenBot;
    private float dist;
    NavMeshAgent nav;

    public Transform pointShot;
    public GameObject _flashPref;
    public Flag _flag;

    float interval;
    int randint;
    public int vse;

    public int vse1;

    public int HP = 100;

    // Start is called before the first frame update
    void Start()
    {
        randint = Random.Range(1, 11);
        greenBot = GameObject.Find("greenBot (" + randint + ")");
        // Debug.Log("GreenStick (" + randint + ")");
        nav = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        greenBot = GameObject.FindGameObjectWithTag("GreenStick");
        dist = Vector3.Distance(greenBot.transform.position, transform.position);
    
        Vector3 direction = greenBot.transform.position -  transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation,  rotation, 3f * Time.deltaTime);
        if(dist  < 5f) {
             nav.enabled = false;
             if(interval <= 0f) {
  
                Instantiate(_flashPref, pointShot.transform.position, pointShot.transform.rotation );
                greenBot.GetComponent<GreenStick>().HP -= 25;
                interval = 1f;
             }
             else {
                 interval -= Time.deltaTime;
             }
        }
        else {
  
            nav.enabled = true;
            nav.SetDestination(greenBot.transform.position); 
        }

        if(greenBot.GetComponent<GreenStick>().HP <= 0) {
            Destroy(greenBot.gameObject);
        }


    }


}
