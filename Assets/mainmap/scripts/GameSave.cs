using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSave : MonoBehaviour
{
    public GameObject player,window;
    public int Secne, saveCount;
    // Start is called before the first frame update
    void Start()
    {
        gameLoad();
    


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
    public void gameExit()
    {
        Application.Quit();
    }
}
