using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OP_playerMove : MonoBehaviour
{
    public Gmaemgr Gmaemgr;
    Rigidbody2D rb;
    public float moveX, moveY;
    Animator anim;
    //Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        moveX = rb.velocity.x;


    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveX, moveY);
        if (moveY == -1)
        {
            print("엄");
            anim.SetFloat("left", Mathf.Abs(moveY));
        }
        if(moveX == 1)
        {
            anim.SetFloat("right", Mathf.Abs(moveX));
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "stop")
        {
            print("충돌 작동확인");
            moveY = rb.velocity.y;
            moveX = 1;
        }
        if (collision.gameObject.tag == "stageUp")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
    }
}
