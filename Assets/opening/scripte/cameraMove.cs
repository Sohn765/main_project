using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public int speed = -3;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
