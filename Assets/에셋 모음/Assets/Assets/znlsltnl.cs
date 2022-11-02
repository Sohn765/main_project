using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class znlsltnl : MonoBehaviour
{
    public GameObject uiClear;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(uiClear);
        }
        
    }


}
