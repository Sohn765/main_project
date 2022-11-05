using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class blink : MonoBehaviour
{
    public GameObject flashingBlink;
   
 
    void Start()
    {
        flashingBlink.SetActive(false);
        StartCoroutine(Mycoruoutine());
    }

    void Update()
    {
        
    }
    public IEnumerator Mycoruoutine()
    {
        int count = 0;
        while (count < 150)
        {
            flashingBlink.SetActive(true);
            yield return new WaitForSeconds(0.9f);
            flashingBlink.SetActive(false);
            yield return new WaitForSeconds(0.9f);
            count++;
        }
    }
}


