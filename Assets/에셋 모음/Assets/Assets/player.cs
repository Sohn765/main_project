using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveX, moveY, Speed = 10f , addf;
    public int jumpcount = 1;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public int count;
    public GameObject uiclear;
    public int gameclear;
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveX * Speed, rb.velocity.y);
        
        if (Input.GetKeyDown(KeyCode.Space) && jumpcount == 1)
        {
            rb.AddForce(Vector2.up * addf, ForceMode2D.Impulse);
            jumpcount = 0;
        }
        if (count == gameclear)
        {
            uiclear.SetActive(true);
            Time.timeScale = 0;
        }
        if (moveX == 1) sr.flipX = false;
        if (moveX == -1) sr.flipX = true;
        if(rigid.velocity.y < 0)
        {
            Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));
            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));
            if (rayHit.collider != null)
            {
                if (rayHit.distance < 0.5f)
                {
                    jumpcount = 1;
                }
            }
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            count+=1;
            print("ÄÚÀÎ");

        }
        

    }

}
