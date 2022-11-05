using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointgo : MonoBehaviour
{
    public GameObject player , point;
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
        if(collision.gameObject.tag == "Player")
        {
            player.transform.position = point.transform.position;   
        }
    }
}
