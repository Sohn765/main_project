using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSave : MonoBehaviour
{
    public GameObject player,window;
    public int Secne, saveCount;
    public Slider Slider;
    public Text progres_text;


    // Start is called before the first frame update
    void Start()
    {
        gameLoad();
        progres();


    }

    // Update is called once per frame  
    void Update()
    {
        
    }

    public void gameSave()
    {
        PlayerPrefs.SetFloat("PlayerX", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", player.transform.position.y);
        PlayerPrefs.SetInt("Secne", Secne);

        window.SetActive(false);



    }
    public void gameLoad()
    {
        int Secne1 = PlayerPrefs.GetInt("Secne");
        if (!PlayerPrefs.HasKey("PlayerX") || Secne != Secne1)
        {
            return;
        }
        float x = PlayerPrefs.GetFloat("PlayerX");
        float y = PlayerPrefs.GetFloat("PlayerY");

        player.transform.position = new Vector3(x, y, 0);
        
    }
    public void progres()
    {
        int coding_game = PlayerPrefs.GetInt("GameClear_count");
        print(coding_game);
        if (!PlayerPrefs.HasKey("GameClear_count"))
        {
            return;
        }
        if (coding_game == 1)
        {
            progres_text.text = "20%";
            Slider.value = 0.2f;
        }

    }
    public void gameExit()
    {
        Application.Quit();
    }
}
