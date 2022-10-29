using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    public Slider progressbar;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LodeScene());
    }

    // Update is called once per frame
    IEnumerator LodeScene()
    {
        float loadcount = 0;
        while(progressbar.value < 1f){
            loadcount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            progressbar.value  = loadcount;
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene(8);

        
    }
}
