using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yap : MonoBehaviour
{
   public GameObject blockExit;
    public yapyap main;

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            main.yapssi();
    }

    
    








}
  

