using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public float Speed;
    float moveX,moveY;
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer src;
    public GameObject boy,girl,mainTalk,playgame,talkmgr, npc_Talk;
    public int talkend, npcCount, maintalkCount;
    public Text text;
    

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        src = gameObject.GetComponent<SpriteRenderer>();
        talkmgr.SetActive(false);
    }


    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(moveX*Speed,moveY*Speed);
        animator.SetFloat("moveX", Mathf.Abs(moveX));
        animator.SetFloat("moveY", moveY);
        if (moveX == -1) src.flipX = false;
        if (moveX == 1) src.flipX = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "girl")
        {
            mainTalk.SetActive(true);
            boy.SetActive(false);
            talkmgr.SetActive(true);
            maintalkCount++;
            Time.timeScale = 0;
        }
        if (collision.gameObject.tag == "gameplay" && talkend == 1)
        {
            playgame.SetActive(true);
        }

        if (collision.gameObject.tag == "npc1")
        {
            npc_Talk.SetActive(true);
            text.text = "집에 보내 주세요";
            npcCount++;
            talkmgr.SetActive(true);

        }

    }


}
