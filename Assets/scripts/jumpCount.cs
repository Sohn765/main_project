using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpCount : MonoBehaviour
{
    public player player;
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
        player.jumpcount = 1;
    }
}