using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_start : MonoBehaviour
{
    public Image image;
    public GameObject button;
    public GameObject text,SaveLoad;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        print("버튼클릭");
        if (!PlayerPrefs.HasKey("PlayerX"))
        {

            FadeButton();
        }
        else
        {
            SaveLoad.SetActive(true);
        }
        
    }
    public void FadeButton()
    {
        if (SaveLoad.activeSelf)
        {
            SaveLoad.SetActive(false);
        }
        button.SetActive(false);
        text.SetActive(false);
        PlayerPrefs.DeleteAll();
        StartCoroutine(FadeCoroutine());


    }
    IEnumerator FadeCoroutine()
    {
        float fadeCount = 0;
        while(fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            image.color = new Color(0, 0, 0, fadeCount);
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
        
    
}
