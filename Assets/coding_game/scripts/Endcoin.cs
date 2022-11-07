using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endcoin : MonoBehaviour
{
    public GameObject okey,nokey;
    public player per;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (per.key2Count == 1 )
        {
            okey.SetActive(true);
        }
        if (per.key2Count == 0 )
        {
            nokey.SetActive(true);
        }
    }
}

