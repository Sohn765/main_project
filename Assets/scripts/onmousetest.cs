using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onmousetest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        print("gma..");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("gma..");
    }
}
