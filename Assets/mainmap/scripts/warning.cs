using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class warning : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public GameObject W,M;
    public AudioSource audioSource;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "warning")
        {
            audioSource.Play();
            W.SetActive(true);
            M.SetActive(true);
            text.text = "여긴 가면 안 될 것 같다";
        }

        if (collision.gameObject.tag == "warning11")
        {
            audioSource.Play();
            W.SetActive(true);
            M.SetActive(true);
            text.text = "잠긴 것 같다";
        }
        if (collision.gameObject.tag == "computerClear")
        {
<<<<<<< HEAD
            audioSource.Play();
            W.SetActive(true);
            M.SetActive(true);
            text.text = "이미 들린 곳이다";
=======
            int coding_game = PlayerPrefs.GetInt("codingGameClear_count");
            if (coding_game == 1)
            {
                W.SetActive(true);
                M.SetActive(true);
                text.text = "이미 들린 곳이다";
                return;
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene(6);


>>>>>>> 587035bfff0573d04ce81471de233ea8f1d2274e
        }

    }


    
}
