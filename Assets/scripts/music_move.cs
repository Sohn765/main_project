using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class music_move : MonoBehaviour
{
    public float minX, maxX, startTime, moveSpeed;
   //  public GameObject player;
    private int sign = -1;
    
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= startTime)
        transform.position += new Vector3(moveSpeed * Time.deltaTime * sign, 0);

        if (transform.position.x <= minX || transform.position.x >= maxX)
            sign *= -1;
    }




}
