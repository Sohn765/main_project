using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yap : MonoBehaviour
{
    public GameObject blockExit;
    void Start()
    {
        

    }

    
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            blockExit.SetActive(false);
        }
    }










}
  

