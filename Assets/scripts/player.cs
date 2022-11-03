using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveX, moveY, Speed = 10f , addf;
    public int jumpcount = 1;
    public Rigidbody2D rb;
    public SpriteRenderer sr,dark, dark1;
    public int count , incount = 0;
    public GameObject uiclear,fake,real,tlie;
    public int gameclear;
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
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
            print("코인");

        }
        

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bang")
        {
            if (Input.GetKey(KeyCode.E))
            {
                fake.SetActive(true);
            }
        }
        if (collision.gameObject.tag == "real")
        {
            if (Input.GetKey(KeyCode.E))
            {
                real.SetActive(true);
                tlie.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dark" ){
            print("충돌!");
            StartCoroutine(fadedark());
        }
        


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dark")
        {
            print("충돌!");
            StartCoroutine(fadeOutdark());
        }
    }
    IEnumerator fadedark()
    {
        print("실행!");
        float count = 1;
        while(count > 0)
        {
            print("반복");
            count -= 0.05f;
            yield return new WaitForSeconds(0.01f);
            dark.color = new Color(0, 0, 0, count);
            dark1.color = new Color(0, 0, 0, count);

        }
    }
    IEnumerator fadeOutdark()
    {
        print("실행!");
        float count = 0;
        while (count < 1.0f)
        {
            print("반복");
            count += 0.05f;
            yield return new WaitForSeconds(0.01f);
            dark.color = new Color(255, 255, 255, count);
            dark1.color = new Color(255, 255, 255, count);

        }
    }
}
