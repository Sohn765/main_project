using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class music_move : MonoBehaviour
{
    Vector2 target = new Vector2(5, 10);
    Vector2 target1 = new Vector2(-5, 10);
    
    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, 0.1f);
        StartCoroutine("moving");
       
    }

  


}
