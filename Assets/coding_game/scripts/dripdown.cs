using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dripdown : MonoBehaviour
{
    public bool playerCheck;
    PlatformEffector2D platformObject;

    void Start()
    {
        playerCheck = false;
        platformObject = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && playerCheck == true)
        {
            platformObject.rotationalOffset = 180f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            platformObject.rotationalOffset = 0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            playerCheck = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        playerCheck = false;
    }
}
