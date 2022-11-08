using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuSet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
    }

    public void Goback()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }
}
