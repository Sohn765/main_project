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
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "player")
        {
            player.incount = 1;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.incount =0;
    }
}
