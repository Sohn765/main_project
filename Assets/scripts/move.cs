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
    public GameObject boy,girl,mainTalk,playgame;
    public int talkend;





    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        src = gameObject.GetComponent<SpriteRenderer>();
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
        if(collision.gameObject.tag == "2floorGo")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(5);
        }
        if (collision.gameObject.tag == "3floorGo")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(6);
        }
        if (collision.gameObject.tag == "computerGo")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(7);
        }
        if(collision.gameObject.tag == "girl")
        {
            mainTalk.SetActive(true);
            boy.SetActive(false);
        }
        if (collision.gameObject.tag == "gameplay" && talkend == 1)
        {
            playgame.SetActive(true);
        }
    }



}
