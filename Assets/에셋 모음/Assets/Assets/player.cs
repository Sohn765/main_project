using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 0.1f;
    public float jump = 5f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public int count;
    public GameObject uiclear;
    public int gameclear;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
            sr.flipX = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            sr.flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jump),ForceMode2D.Impulse);
        }
        if (count == gameclear)
        {
            uiclear.SetActive(true);
            Time.timeScale = 0;
        }
     
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            count += 1;
        }
        

    }

}
