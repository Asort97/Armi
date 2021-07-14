using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Flag : MonoBehaviour
{

    public float progress;

    public GameObject[] redSticks;
    public GameObject[] greenSticks;

    public GameObject whiteFlag;

    public GameObject redFlag;
    public GameObject greenFlag;

    public bool Ready;

    public Slider slide;


    public GameObject WinPanel;

    // Update is called once per fram   e
    void Update()
    {

        redSticks = GameObject.FindGameObjectsWithTag("RedStick"); 
        greenSticks = GameObject.FindGameObjectsWithTag("GreenStick");

        slide.value = progress;

        if(redSticks.Length == greenSticks.Length) {
            progress = 0f;
        }
        if(redSticks.Length > greenSticks.Length && progress >= -50f) {
            progress -= 5f * Time.deltaTime;

        }
        if(redSticks.Length < greenSticks.Length && progress <= 50f) {
            progress += 5f * Time.deltaTime;
        }

        if(progress >= 50f) {
            Ready = true;
            WinPanel.SetActive(true);
            greenFlag.SetActive(true);
            redFlag.SetActive(false);
            whiteFlag.SetActive(false);
        }
        if(progress <= -50f) {
            greenFlag.SetActive(false);
            redFlag.SetActive(true);
            whiteFlag.SetActive(false);
        }
        else {
            whiteFlag.SetActive(true);
        }
    }

}
