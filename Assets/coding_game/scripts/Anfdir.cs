using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anfdir : MonoBehaviour
{
    public speedUp spu;
    public player plyer;
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
            plyer.Speed = 15;
            print("¼Óµµ ¾÷");
            spu.anffir.SetActive(false);
            spu.anffir.transform.position = spu.reset.transform.position;
        }
    }


}
