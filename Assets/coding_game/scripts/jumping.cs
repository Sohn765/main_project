using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping : MonoBehaviour
{
    Animator jumpPole_ani;
    // Start is called before the first frame update
    void Start()
    {
        jumpPole_ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StartCoroutine(jumpP());
        }
       
    }

    IEnumerator jumpP()
    {
        jumpPole_ani.SetFloat("up", 1);
        yield return new WaitForSeconds(2f);
        jumpPole_ani.SetFloat("up", 0);
    }
}
