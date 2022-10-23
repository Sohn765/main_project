using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float Speed;
    float moveX,moveY;
    Rigidbody2D rb;
    GameObject player;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector2(moveX, moveY) * Time.deltaTime * Speed);

    }

    private void OntiggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);

        }
    }



}
