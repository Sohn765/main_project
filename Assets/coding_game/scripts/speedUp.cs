using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedUp : MonoBehaviour
{
    public GameObject anffir,reset;

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
        if (collision.gameObject.tag == "Player")
        {
            anffir.SetActive(true);

        }
    }
}
