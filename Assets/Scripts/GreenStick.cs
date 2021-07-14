using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GreenStick : MonoBehaviour
{
    private GameObject redBot;
    private float dist;
    NavMeshAgent nav;

    public Transform pointShot;
    public GameObject _flashPref;
    public Flag _flag;

    public int HP = 100;

    public int vse;

    int randint;
    float interval;


    public GameObject greenColor;
    public GameObject yellowColor;
    public GameObject redColor;

    // Start is called before the first frame update
    void Start()
    {
        randint = Random.Range(1, 11);
        redBot = GameObject.Find("redBot (" + randint + ")");
        // Debug.Log("redBot (" + randint + ")");
        nav = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {

        if(HP < 80) {
            greenColor.SetActive(false);
            yellowColor.SetActive(true);
            redColor.SetActive(false);
        }
        if(HP < 40) {
            greenColor.SetActive(false);
            yellowColor.SetActive(false);
            redColor.SetActive(true);
        }
        else {
            greenColor.SetActive(true);
            yellowColor.SetActive(false);
            redColor.SetActive(false);
        }
        redBot = GameObject.FindGameObjectWithTag("RedStick");
        dist = Vector3.Distance(redBot.transform.position, transform.position);

        Vector3 direction = redBot.transform.position -  transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        
        transform.rotation = Quaternion.Lerp(transform.rotation,  rotation, 3f * Time.deltaTime);
        if(dist  < 5f) {
            nav.enabled = false;
            if(interval <= 0f) {
                Instantiate(_flashPref, pointShot.transform.position, pointShot.transform.rotation);
                redBot.GetComponent<RedStick>().HP -= 25;
                interval = 1f;
            }
            else {
                interval -= Time.deltaTime;
            }
        }

        else {
            nav.enabled = true;
            nav.SetDestination(redBot.transform.position); 
        }

        if(redBot.GetComponent<RedStick>().HP <= 0) {
            Destroy(redBot.gameObject);
        }

    }

    private void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "ZonaGreen") {
            Debug.Log("ININI");
            if(HP < 150) {
                HP += 50;
            }
            
        }
    }


}
