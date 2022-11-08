using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneLoad()
    {
        int Scene = PlayerPrefs.GetInt("Secne");
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene);
    }
}
