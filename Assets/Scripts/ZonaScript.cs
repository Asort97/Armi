using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaScript : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(wait(4f));
    }
    IEnumerator wait(float time) {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
