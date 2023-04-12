using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main_move : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    float moveX, moveY;
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer src;
    public GameObject menuSet;
<<<<<<< HEAD
<<<<<<< HEAD
    AudioSource audioSource;
=======
    public AudioSource audioSource;
    bool ismoving = false;
>>>>>>> 96d6392bdb715ac90d5eae4cceee995281b5045c
=======

>>>>>>> parent of 85f1fdd (수정본)


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
        rb.velocity = new Vector2(moveX * Speed, moveY * Speed);
        animator.SetFloat("moveX", Mathf.Abs(moveX));
        animator.SetFloat("moveY", moveY);
        if (Input.GetKeyDown(KeyCode.LeftShift)) Speed = 10;
        if (Input.GetKeyUp(KeyCode.LeftShift)) Speed = 4;

        if (moveX == -1) src.flipX = false;
        if (moveX == 1) src.flipX = true;

        if (Input.GetButtonDown("Cancel"))
        {
            if (menuSet.activeSelf)
            {
                menuSet.SetActive(false);
            }
            else
            {
                menuSet.SetActive(true);
            }
                

        }

        if (rb.velocity.x != 0)
            ismoving = true;
        else
            ismoving = false;


        if (ismoving)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
            audioSource.Stop();

    }

    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "2floorGo")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        }
        if (collision.gameObject.tag == "3floorGo")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(5);
        }
        if (collision.gameObject.tag == "computerGo")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(6);
        }
        if (collision.gameObject.tag == "musicGo")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(11);
        }
       

    }
}

      


